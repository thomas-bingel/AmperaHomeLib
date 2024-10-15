// See https://aka.ms/new-console-template for more information

namespace AmperaHome.WebApiClient.Models;

public class RsaPubResponse
{

    [JsonPropertyName("nextReqId")]
    public string NextRequestId { get; set; } = default!;


    [JsonPropertyName("pubKey")]
    public string PublicKey { get; set; } = default!;
}
