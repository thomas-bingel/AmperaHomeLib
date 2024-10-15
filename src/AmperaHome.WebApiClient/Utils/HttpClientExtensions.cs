using System.Diagnostics;
using System.Net.Http.Headers;

namespace AmperaHome.WebApiClient.Utils;

internal static class HttpClientExtensions
{
    public static async Task<T?> GetFromJsonAsync<T>(
        this HttpClient httpClient,
        string url,
        Dictionary<string, string> queryParameters,
        AuthenticationHeaderValue authorization)
    {
        string query;
        using (var content = new FormUrlEncodedContent(queryParameters))
        {
            query = content.ReadAsStringAsync().Result;
        }

        var request = new HttpRequestMessage(HttpMethod.Get, url + "?" + query);
        request.Headers.Authorization = authorization;

        var response = await httpClient.SendAsync(request);
        var responseString = await response.Content.ReadAsStringAsync();

        Debug.WriteLine(responseString);

        return JsonSerializer.Deserialize<T>(responseString);
    }
}
