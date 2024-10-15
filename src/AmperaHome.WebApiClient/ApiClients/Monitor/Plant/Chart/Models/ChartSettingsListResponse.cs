namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;

public class ChartSettingsListResponse
{
    [JsonPropertyName("chartName")]
    public string ChartName { get; set; } = default!;

    [JsonPropertyName("chartType")]
    public int ChartType { get; set; } = default!;

    [JsonPropertyName("isShow")]
    public int IsShow { get; set; } = default!;

    [JsonPropertyName("plantType")]
    public int PlantType { get; set; } = default!;

    [JsonPropertyName("sort")]
    public int Sort { get; set; } = default!;
}
