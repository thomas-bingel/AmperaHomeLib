namespace AmperaHome.WebApiClient.ApiClients.Sys.Tool.Models;

public class ToolsResponse
{
    [JsonPropertyName("iconUrl")]
    public string IconUrl { get; set; } = default!;

    [JsonPropertyName("isRequestRedDotNum")]
    public int IsRequestRedDotNum { get; set; } = default!;

    [JsonPropertyName("isShowBeta")]
    public int IsShowBeta { get; set; } = default!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;

    [JsonPropertyName("toolID")]
    public int ToolId { get; set; } = default!;

    [JsonPropertyName("toolType")]
    public int ToolType { get; set; } = default!;
}
