namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;

public class XAxisBean
{

    [JsonPropertyName("coordinateList")]
    public List<string> CoordinateList { get; set; } = default!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;
}
