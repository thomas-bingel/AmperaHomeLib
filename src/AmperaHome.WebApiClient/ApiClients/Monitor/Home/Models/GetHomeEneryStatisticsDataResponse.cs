namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;

public class GetHomeEneryStatisticsDataResponse
{
    [JsonPropertyName("alarmNumPending")]
    public int AlarmNumPending { get; set; } = default!;

    [JsonPropertyName("currentUserId")]
    public string CurrentUserId { get; set; } = default!;

    [JsonPropertyName("lastDayPvEnergy")]
    public int LastDayPvEnergy { get; set; } = default!;

    [JsonPropertyName("lastMonthPvEnergy")]
    public int LastMonthPvEnergy { get; set; } = default!;

    [JsonPropertyName("lastYearPvEnergy")]
    public int LastYearPvEnergy { get; set; } = default!;

    [JsonPropertyName("monthPvEnergy")]
    public double MonthPvEnergy { get; set; } = default!;

    [JsonPropertyName("plantTreeNum")]
    public double PlantTreeNum { get; set; } = default!;

    [JsonPropertyName("reduceCo2")]
    public double ReduceCo2 { get; set; } = default!;

    [JsonPropertyName("reduceCo2Unit")]
    public string ReduceCo2Unit { get; set; } = default!;

    [JsonPropertyName("roleType")]
    public string RoleType { get; set; } = default!;

    [JsonPropertyName("todayPvEnergy")]
    public double TodayPvEnergy { get; set; } = default!;

    [JsonPropertyName("totalCoal")]
    public double TotalCoal { get; set; } = default!;

    [JsonPropertyName("totalPvEnergy")]
    public double TotalPvEnergy { get; set; } = default!;

    [JsonPropertyName("yearCoal")]
    public double YearCoal { get; set; } = default!;

    [JsonPropertyName("yearPlantTreeNum")]
    public double YearPlantTreeNum { get; set; } = default!;

    [JsonPropertyName("yearPvEnergy")]
    public double YearPvEnergy { get; set; } = default!;

    [JsonPropertyName("yearReduceCo2")]
    public double YearReduceCo2 { get; set; } = default!;
}
