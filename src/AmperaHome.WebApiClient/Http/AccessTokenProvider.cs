namespace AmperaHome.WebApiClient.Http;

internal class AccessTokenProvider : IAccessTokenProvider
{
    private readonly string _amperaBaseUrl;
    private readonly string _saltKey;
    private readonly string _appProjectName;
    private string? _username;
    private string? _password;
    private readonly ILogger<AccessTokenProvider>? _logger;
    private readonly HttpClient _httpClient;
    private readonly IPublicKeyProvider _publicKeyProvider;

    public AccessTokenProvider(
        IOptions<AmperaHomeWebApiOptions> options,
        HttpClient httpClient,
        IPublicKeyProvider publicKeyProvider,
        ILogger<AccessTokenProvider>? logger)
    {
        _logger = logger;
        _httpClient = httpClient;
        _publicKeyProvider = publicKeyProvider;

        var optionValues = options.Value ?? throw new ArgumentNullException(nameof(options));

        _amperaBaseUrl = optionValues.AmperaHomeBaseUrl ??
            throw new AmeraHomeException("LoginUrl is null");

        _saltKey = optionValues.SaltKey ??
            throw new AmeraHomeException("SaltKey is null");

        _appProjectName = optionValues.AppProjectName ??
            throw new AmeraHomeException("AppProjectName is null");

        if (!string.IsNullOrEmpty(optionValues.Username))
            _username = optionValues.Username;

        if (!string.IsNullOrEmpty(optionValues.Password))
            _password = optionValues.Password;
    }

    public void SetCredentials(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public async Task<string> GetAccessTokenAsync()
    {
        if (_username == null || _password == null)
            throw new AmeraHomeException("Username or password is null");

        var publicKeyResponse = await _publicKeyProvider.GetPublicKey();

        var encryptedPassword = EncryptUtils.EncryptRSA2Base64(
            Encoding.UTF8.GetBytes(_password),
            publicKeyResponse.PublicKey,
            512,
            "RSA/ECB/PKCS1Padding");

        var loginRequestMap = new Dictionary<string, string>
        {
            { "appProjectName", _appProjectName },
            { "loginType", "1" },
            { "password", encryptedPassword },
            { "reqId", publicKeyResponse.NextRequestId },
            { "username", _username }
        };

        var requestMap = Helper.ToEncodeMap(loginRequestMap, _saltKey);
        var formValues = requestMap.Select(_ => new KeyValuePair<string, string>(_.Key, _.Value!.ToString()));
        var dataContent = new FormUrlEncodedContent(formValues);

        using var req = new HttpRequestMessage(HttpMethod.Post, _amperaBaseUrl + "/app/sys/login") { Content = dataContent };
        var loginResponse = await _httpClient.SendAsync(req);

        var loginResponseContent = await loginResponse.Content.ReadAsStringAsync();
        var loginResponseObject = JsonSerializer.Deserialize<BaseResponse<LoginResponse>>(loginResponseContent);

        _logger?.LogDebug("Login response: {LoginResponse}", loginResponseObject);

        if (loginResponseObject == null || loginResponseObject.ErrorCode != 0)
            throw new AmeraHomeException("Failed to login " + loginResponseObject?.ErrorMessage);

        return loginResponseObject.Data.AccessToken;
    }
}