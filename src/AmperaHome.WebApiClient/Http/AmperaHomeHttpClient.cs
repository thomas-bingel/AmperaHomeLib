using System.Net.Http.Headers;

namespace AmperaHome.WebApiClient.Http;

public interface IAmperaHomeHttpClient
{
    Task<T> GetFromJsonAsync<T>(string url, Dictionary<string, string>? queryParameters = null) where T : class, IBaseResponse;
}
internal class AmperaHomeHttpClient : IAmperaHomeHttpClient
{
    private readonly HttpClient _httpClient;

    private readonly IAccessTokenProvider accessTokenProvider;
    private readonly ILogger<AmperaHomeHttpClient>? logger;
    private readonly string _saltKey;
    private readonly string _appProjectName;


    private readonly string SIGNATURE = "signature";
    private readonly string SIGN_PARAMS = "signParams";

    public AmperaHomeHttpClient(
        IHttpClientFactory factory,
        IAccessTokenProvider _accessTokenProvider,
        IOptions<AmperaHomeWebApiOptions> options,
        ILogger<AmperaHomeHttpClient>? _logger)
    {
        var optionValues = options.Value ?? throw new ArgumentNullException(nameof(options));
        _saltKey = optionValues.SaltKey ??
             throw new AmeraHomeException(nameof(optionValues.SaltKey) + " is null");

        _appProjectName = optionValues.AppProjectName ??
          throw new AmeraHomeException(nameof(optionValues.AppProjectName) + " is null");

        accessTokenProvider = _accessTokenProvider;
        logger = _logger;
        _httpClient = factory.CreateClient(HttpClientNames.AmperaHomeWebApiClient);
    }

    public async Task<T> GetFromJsonAsync<T>(
        string url,
        Dictionary<string, string>? queryParameters = null) where T : class, IBaseResponse
    {
        queryParameters ??= [];

        AddPropertiesToQueryParameters(queryParameters);

        string query;
        using (var content = new FormUrlEncodedContent(queryParameters))
        {
            query = content.ReadAsStringAsync().Result;
        }

        var request = new HttpRequestMessage(HttpMethod.Get, url + "?" + query);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await accessTokenProvider.GetAccessTokenAsync());

        var response = await _httpClient.SendAsync(request);
        var responseString = await response.Content.ReadAsStringAsync();

        logger?.LogDebug("HttpClient response {Response}", responseString);


        var responseObject = JsonSerializer.Deserialize<T>(responseString);


        if (responseObject == null || responseObject.ErrorCode != 0)
            throw new AmeraHomeException("Request failed " + responseObject?.ErrorMessage);

        return responseObject;
    }

    public void AddPropertiesToQueryParameters(Dictionary<string, string> paramMap)
    {
        paramMap.Remove(SIGN_PARAMS);
        paramMap.Remove(SIGNATURE);

        paramMap.TryAdd("timeStamp", DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString());
        paramMap.TryAdd("clientId", "esolar-app");
        paramMap.TryAdd("clientDate", DateTime.Now.ToString("yyyy-MM-dd"));
        paramMap.TryAdd("appVersion", "1.0");
        paramMap.TryAdd("lang", "de");
        paramMap.TryAdd("language", "de");
        paramMap.TryAdd("appProjectName", _appProjectName);
        paramMap.TryAdd("platform", "Android");

        int i = paramMap.Count;
        while (i < 5)
        {
            paramMap.Add("trimParam" + i, "trimParam" + i);
            i++;
        }

        var array = paramMap.Keys.ToArray();
        Array.Sort(array);

        var sb = new StringBuilder();
        var sb2 = new StringBuilder();

        foreach (var obj in array)
        {
            if (sb.Length > 0)
            {
                sb.Append('&');
            }

            if (sb2.Length > 0)
            {
                sb2.Append(',');
            }

            sb.Append(obj);
            sb.Append('=');
            sb.Append(paramMap[obj].ToString().Trim());
            sb2.Append(obj);
        }

        sb.Append("&key=");
        sb.Append(_saltKey);

        var md5HashString = EncryptUtils.EncryptMD5ToString(sb.ToString()).ToLower();
        var sha1 = EncryptUtils.EncryptSHA1ToString(md5HashString).ToUpper();

        paramMap.Add(SIGNATURE, sha1);

        paramMap.Add(SIGN_PARAMS, sb2.ToString());
    }

}
