namespace AmperaHome.WebApiClient.ApiClients.Monitor.PlantAchievements.Models;

public class GetAchievementResponse
{
    [JsonPropertyName("batteryChargingFromPvDayAverage")]
    public double BatteryChargingFromPvDayAverage { get; set; } = default!;

    [JsonPropertyName("batteryChargingFromPvTotal")]
    public double BatteryChargingFromPvTotal { get; set; } = default!;

    [JsonPropertyName("batteryChargingHighestDate")]
    public string BatteryChargingHighestDate { get; set; } = default!;

    [JsonPropertyName("batteryChargingHighestOne")]
    public double BatteryChargingHighestOne { get; set; } = default!;

    [JsonPropertyName("co2UnitOfWeight")]
    public string Co2UnitOfWeight { get; set; } = default!;

    [JsonPropertyName("deviceSns")]
    public string DeviceSns { get; set; } = default!;

    [JsonPropertyName("isInstallMeter")]
    public int IsInstallMeter { get; set; } = default!;

    [JsonPropertyName("operationDays")]
    public string OperationDays { get; set; } = default!;

    [JsonPropertyName("plantCreateDate")]
    public string PlantCreateDate { get; set; } = default!;

    [JsonPropertyName("plantName")]
    public string PlantName { get; set; } = default!;

    [JsonPropertyName("plantUid")]
    public string PlantUid { get; set; } = default!;

    [JsonPropertyName("pvEnergyDayAverage")]
    public double PvEnergyDayAverage { get; set; } = default!;

    [JsonPropertyName("pvEnergyHighestDate")]
    public string PvEnergyHighestDate { get; set; } = default!;

    [JsonPropertyName("pvEnergyHighestOne")]
    public double PvEnergyHighestOne { get; set; } = default!;

    [JsonPropertyName("pvEnergyTotal")]
    public double PvEnergyTotal { get; set; } = default!;

    [JsonPropertyName("sajLogo")]
    public string SajLogo { get; set; } = default!;

    [JsonPropertyName("sellEnergyDayAverage")]
    public double SellEnergyDayAverage { get; set; } = default!;

    [JsonPropertyName("sellEnergyHighestDate")]
    public string SellEnergyHighestDate { get; set; } = default!;

    [JsonPropertyName("sellEnergyHighestOne")]
    public double SellEnergyHighestOne { get; set; } = default!;

    [JsonPropertyName("sellEnergyTotal")]
    public double SellEnergyTotal { get; set; } = default!;

    [JsonPropertyName("todayHourHighestDate")]
    public string TodayHourHighestDate { get; set; } = default!;

    [JsonPropertyName("todayHourHighestOne")]
    public double TodayHourHighestOne { get; set; } = default!;

    [JsonPropertyName("totalPlantTreeNum")]
    public double TotalPlantTreeNum { get; set; } = default!;

    [JsonPropertyName("totalReduceCo2")]
    public double TotalReduceCo2 { get; set; } = default!;

    [JsonPropertyName("type")]
    public int Type { get; set; } = default!;

    [JsonPropertyName("userHead")]
    public string UserHead { get; set; } = default!;

    [JsonPropertyName("userUid")]
    public string UserUid { get; set; } = default!;
}
