namespace AmperaHome.WebApiClient.Http;

public class PublicKeyResponse
{
    public required byte[] PublicKey { get; set; }
    public required string NextRequestId { get; set; }
}