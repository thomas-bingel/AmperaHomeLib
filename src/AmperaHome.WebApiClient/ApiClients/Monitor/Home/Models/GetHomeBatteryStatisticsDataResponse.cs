namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;

public class GetHomeBatteryStatisticsDataResponse
{
    [JsonPropertyName("batteryNumCharging")]
    public int BatteryNumCharging { get; set; } = default!;

    [JsonPropertyName("batteryNumDischarge")]
    public int BatteryNumDischarge { get; set; } = default!;

    [JsonPropertyName("batteryNumFullyCharged")]
    public int BatteryNumFullyCharged { get; set; } = default!;

    [JsonPropertyName("batteryNumOffline")]
    public int BatteryNumOffline { get; set; } = default!;

    [JsonPropertyName("batteryNumStandby")]
    public int BatteryNumStandby { get; set; } = default!;

    [JsonPropertyName("batteryNumTotal")]
    public int BatteryNumTotal { get; set; } = default!;

    [JsonPropertyName("batteryOnlineRate")]
    public string BatteryOnlineRate { get; set; } = default!;

    [JsonPropertyName("currentUserId")]
    public string CurrentUserId { get; set; } = default!;

    [JsonPropertyName("roleType")]
    public string RoleType { get; set; } = default!;
}
