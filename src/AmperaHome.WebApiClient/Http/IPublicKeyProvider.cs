namespace AmperaHome.WebApiClient.Http;

public interface IPublicKeyProvider
{
    Task<PublicKeyResponse> GetPublicKey();
}
