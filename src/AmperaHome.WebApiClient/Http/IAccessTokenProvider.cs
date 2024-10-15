namespace AmperaHome.WebApiClient.Http;

public interface IAccessTokenProvider
{
    Task<string> GetAccessTokenAsync();
    void SetCredentials(string username, string password);
}
