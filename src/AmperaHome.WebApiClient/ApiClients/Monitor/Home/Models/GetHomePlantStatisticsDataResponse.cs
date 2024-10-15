namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;

public class GetHomePlantStatisticsDataResponse
{
    [JsonPropertyName("currentUserId")]
    public string CurrentUserId { get; set; } = default!;

    [JsonPropertyName("plantNormalRate")]
    public string PlantNormalRate { get; set; } = default!;

    [JsonPropertyName("plantNumAlarm")]
    public int PlantNumAlarm { get; set; } = default!;

    [JsonPropertyName("plantNumNormal")]
    public int PlantNumNormal { get; set; } = default!;

    [JsonPropertyName("plantNumNotMonitor")]
    public int PlantNumNotMonitor { get; set; } = default!;

    [JsonPropertyName("plantNumOffline")]
    public int PlantNumOffline { get; set; } = default!;

    [JsonPropertyName("plantNumTotal")]
    public int PlantNumTotal { get; set; } = default!;

    [JsonPropertyName("plantTotalCapacity")]
    public double PlantTotalCapacity { get; set; } = default!;

    [JsonPropertyName("roleType")]
    public string RoleType { get; set; } = default!;

}
