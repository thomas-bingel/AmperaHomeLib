namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;

public class GetDeviceFlowDataResponse
{

    [JsonPropertyName("batCapcity")]
    public double BatCapcity { get; set; } = default!;

    [JsonPropertyName("batEnergyPercent")]
    public double BatEnergyPercent { get; set; } = default!;

    [JsonPropertyName("batPower")]
    public double BatPower { get; set; } = default!;

    [JsonPropertyName("batteryBrand")]
    public int BatteryBrand { get; set; } = default!;

    [JsonPropertyName("batteryDirection")]
    public int BatteryDirection { get; set; } = default!;

    [JsonPropertyName("batteryPic")]
    public string BatteryPic { get; set; } = default!;

    [JsonPropertyName("batteryStatus")]
    public int BatteryStatus { get; set; } = default!;

    [JsonPropertyName("dataTime")]
    public string DataTime { get; set; } = default!;

    [JsonPropertyName("devicePic")]
    public string DevicePic { get; set; } = default!;

    [JsonPropertyName("deviceSn")]
    public string DeviceSn { get; set; } = default!;

    [JsonPropertyName("ekdTotalLoadPowerwatt")]
    public double EkdTotalLoadPowerwatt { get; set; } = default!;

    [JsonPropertyName("gridDirection")]
    public int GridDirection { get; set; } = default!;

    [JsonPropertyName("gridStatus")]
    public int GridStatus { get; set; } = default!;

    [JsonPropertyName("hasBattery")]
    public int HasBattery { get; set; } = default!;

    [JsonPropertyName("hasMeter")]
    public int HasMeter { get; set; } = default!;

    [JsonPropertyName("initBatPower")]
    public double InitBatPower { get; set; } = default!;

    [JsonPropertyName("moduleFw")]
    public string ModuleFw { get; set; } = default!;

    [JsonPropertyName("moduleModel")]
    public string ModuleModel { get; set; } = default!;

    [JsonPropertyName("moduleSn")]
    public string ModuleSn { get; set; } = default!;

    [JsonPropertyName("outputDirection")]
    public int OutputDirection { get; set; } = default!;

    [JsonPropertyName("plantUid")]
    public string PlantUid { get; set; } = default!;

    [JsonPropertyName("pvDirection")]
    public int PvDirection { get; set; } = default!;

    [JsonPropertyName("pvEfficiency")]
    public double PvEfficiency { get; set; } = default!;

    [JsonPropertyName("refreshInterval")]
    public int RefreshInterval { get; set; } = default!;

    [JsonPropertyName("runningState")]
    public int RunningState { get; set; } = default!;

    [JsonPropertyName("solarPower")]
    public double SolarPower { get; set; } = default!;

    [JsonPropertyName("sysGridPowerwatt")]
    public double SysGridPowerwatt { get; set; } = default!;

    [JsonPropertyName("systemPower")]
    public double SystemPower { get; set; } = default!;

    [JsonPropertyName("totalLoadPowerwatt")]
    public double TotalLoadPowerwatt { get; set; } = default!;

    [JsonPropertyName("totalPvPower")]
    public double TotalPvPower { get; set; } = default!;


    [JsonPropertyName("updateDate")]
    [JsonConverter(typeof(DateTimeConverter))]
    public DateTime? UpdateDate { get; set; } = default!;


    /// <summary>
    /// Ignored. Switches between string and number. Depending on "deviceSn" is set or not
    /// </summary>
    [JsonPropertyName("updateTimeSpan")]
    [JsonIgnore]
    public int UpdateTimeSpan { get; set; } = default!;


    [JsonPropertyName("userMode")]
    public int UserMode { get; set; } = default!;

    [JsonPropertyName("userModeName")]
    public string UserModeName { get; set; } = default!;
}
