namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;

public class YAxisBean
{
    [JsonPropertyName("dataList")]
    public List<string> DataList { get; set; } = default!;

    [JsonPropertyName("baseDataList")]
    public List<string> BaseDataList { get; set; } = default!;

    [JsonPropertyName("groupName")]
    public string GroupName { get; set; } = default!;

    [JsonPropertyName("groupType")]
    public int GroupType { get; set; } = default!;

    [JsonPropertyName("legendName")]
    public string LegendName { get; set; } = default!;

    [JsonPropertyName("tagName")]
    public string TagName { get; set; } = default!;

    [JsonPropertyName("unit")]
    public string Unit { get; set; } = default!;
}
