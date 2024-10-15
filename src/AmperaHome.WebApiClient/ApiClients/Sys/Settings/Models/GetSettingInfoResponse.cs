namespace AmperaHome.WebApiClient.ApiClients.Sys.Settings.Models;

public class GetSettingInfoResponse
{

    [JsonPropertyName("dateFormat")]
    public string DateFormat { get; set; } = default!;

    [JsonPropertyName("dateFormatType")]
    public int DateFormatType { get; set; } = default!;

    [JsonPropertyName("numType")]
    public int NnumType { get; set; } = default!;

    [JsonPropertyName("numTypeName")]
    public string NumTypeName { get; set; } = default!;

    [JsonPropertyName("pushActivityMsg")]
    public int PushActivityMsg { get; set; } = default!;

    [JsonPropertyName("pushAlarm")]
    public int PushAlarm { get; set; } = default!;

    [JsonPropertyName("pushDeviceLog")]
    public int PushDeviceLog { get; set; } = default!;

    [JsonPropertyName("pushMsg")]
    public int PushMsg { get; set; } = default!;

    [JsonPropertyName("pushPlantReport")]
    public int PushPlantReport { get; set; } = default!;

    [JsonPropertyName("pushServiceMsg")]
    public int PushServiceMsg { get; set; } = default!;

    [JsonPropertyName("tempType")]
    public int TempType { get; set; } = default!;

    [JsonPropertyName("tempTypeName")]
    public string TempTypeName { get; set; } = default!;

    [JsonPropertyName("unitType")]
    public int UnitType { get; set; } = default!;

    [JsonPropertyName("unitTypeName")]
    public string UnitTypeName { get; set; } = default!;

}
