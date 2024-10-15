// See https://aka.ms/new-console-template for more information

namespace AmperaHome.WebApiClient.Models;

public class LoginResponse
{

    [JsonPropertyName("expiresIn")]
    public int ExpiresIn { get; set; } = default!;


    [JsonPropertyName("refreshToken")]
    public string RefreshToken { get; set; } = default!;


    [JsonPropertyName("ssgStaffToken")]
    public string SsgStaffToken { get; set; } = default!;


    [JsonPropertyName("token")]
    public string AccessToken { get; set; } = default!;


    [JsonPropertyName("tokenHead")]
    public string TokenHead { get; set; } = default!;


    [JsonPropertyName("wpToken")]
    public string WpToken { get; set; } = default!;
}