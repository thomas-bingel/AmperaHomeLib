namespace AmperaHome.WebApiClient.Http;

internal class PublicKeyProvider : IPublicKeyProvider
{
    private readonly string _getRsaPubUrl;
    private readonly ILogger<PublicKeyProvider>? _logger;
    private readonly HttpClient _httpClient;

    public PublicKeyProvider(IOptions<AmperaHomeWebApiOptions> options, HttpClient httpClient, ILogger<PublicKeyProvider>? logger)
    {
        _logger = logger;
        _httpClient = httpClient;

        var optionValues = options.Value ?? throw new ArgumentNullException(nameof(options));

        _getRsaPubUrl = optionValues.GetRsaPublicKeyUrl ??
            throw new AmeraHomeException("RsaPubUrl is null");
    }

    public async Task<PublicKeyResponse> GetPublicKey()
    {
        _logger?.LogDebug("Requesting public key from url: {RsaPubUrl}", _getRsaPubUrl);

        var getRsaPubResponse = await _httpClient.GetFromJsonAsync<BaseResponse<RsaPubResponse>>(_getRsaPubUrl)
            ?? throw new AmeraHomeException("Unable to get RsaPubResponse");

        var publicKeyString = getRsaPubResponse.Data.PublicKey;
        _logger?.LogDebug("Next Request ID: {NextRequestId} Public key: {PublicKey}", getRsaPubResponse.Data.NextRequestId, publicKeyString);
        var publicKeyBytes = Convert.FromBase64String(publicKeyString);

        return new PublicKeyResponse()
        {
            PublicKey = publicKeyBytes,
            NextRequestId = getRsaPubResponse.Data.NextRequestId,
        };
    }
}
