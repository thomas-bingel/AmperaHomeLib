namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;

public class ChartMultiDataModel
{
    [JsonPropertyName("pileNum")]
    public int PileNum { get; set; } = default!;

    [JsonPropertyName("pileWay")]
    public int PileWay { get; set; } = default!;

    [JsonPropertyName("xAxis")]
    public XAxisBean XAxis { get; set; } = default!;

    [JsonPropertyName("yAxis")]
    public List<YAxisBean> YAxis { get; set; } = default!;

}
