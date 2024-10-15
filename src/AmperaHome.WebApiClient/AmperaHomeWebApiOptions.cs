namespace AmperaHome.WebApiClient;

public class AmperaHomeWebApiOptions
{
    public string? GetRsaPublicKeyUrl { get; set; } = "https://esolarhome-ekd-bak.saj-electric.com/api/v1/sys/getRsaPub";
    public string? AmperaHomeBaseUrl { get; set; } = "https://esolarhome-ekd-bak.saj-electric.com";
    public string? SaltKey { get; set; } = "jcmokL0wc6GSfhRIIfdvTek0bwofFctx";
    public string? AppProjectName { get; set; } = "oem4EKD";
    public string? Username { get; set; }
    public string? Password { get; set; }

}