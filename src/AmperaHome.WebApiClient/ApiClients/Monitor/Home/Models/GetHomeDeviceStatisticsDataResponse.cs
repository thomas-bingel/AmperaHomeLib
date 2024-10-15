namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;

public class GetHomeDeviceStatisticsDataResponse
{
    [JsonPropertyName("currentUserId")]
    public string CurrentUserId { get; set; } = default!;

    [JsonPropertyName("deviceNormalRate")]
    public string DeviceNormalRate { get; set; } = default!;

    [JsonPropertyName("deviceNumAlarm")]
    public int DeviceNumAlarm { get; set; } = default!;

    [JsonPropertyName("deviceNumHistory")]
    public int DeviceNumHistory { get; set; } = default!;

    [JsonPropertyName("deviceNumNormal")]
    public int DeviceNumNormal { get; set; } = default!;

    [JsonPropertyName("deviceNumNotMonitor")]
    public int DeviceNumNotMonitor { get; set; } = default!;

    [JsonPropertyName("deviceNumOffline")]
    public int DeviceNumOffline { get; set; } = default!;

    [JsonPropertyName("deviceNumOnline")]
    public int DeviceNumOnline { get; set; } = default!;

    [JsonPropertyName("deviceNumTotal")]
    public int DeviceNumTotal { get; set; } = default!;

    [JsonPropertyName("roleType")]
    public string RoleType { get; set; } = default!;
}
