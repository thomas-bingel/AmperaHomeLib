namespace AmperaHome.WebApiClient.ApiClients.Sys.User.Models;

public class UserInfoResponse
{
    [JsonPropertyName("allowedToPushMail")]
    public int AllowedToPushMail { get; set; } = default!;

    [JsonPropertyName("brandLogo")]
    public string BrandLogo { get; set; } = default!;

    [JsonPropertyName("country")]
    public string Country { get; set; } = default!;

    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; } = default!;

    [JsonPropertyName("email")]
    public string Email { get; set; } = default!;

    [JsonPropertyName("isEmailValid")]
    public string IsEmailValid { get; set; } = default!;
    
    [JsonPropertyName("loginName")]
    public string LoginName { get; set; } = default!;

    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = default!;

    [JsonPropertyName("phone")]
    public string Phone { get; set; } = default!;

    [JsonPropertyName("subOfficeIcon")]
    public int SubOfficeIcon { get; set; } = default!;

    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; } = default!;

    [JsonPropertyName("timeZoneName")]
    public string TimeZoneName { get; set; } = default!;

    [JsonPropertyName("userHead")]
    public string UserHead { get; set; } = default!;

    [JsonPropertyName("userType")]
    public string UserType { get; set; } = default!;

    public bool NeedEmailValid()
    {
        return !string.IsNullOrEmpty(Email) && "N".Equals(IsEmailValid, StringComparison.CurrentCultureIgnoreCase);
    }
}
