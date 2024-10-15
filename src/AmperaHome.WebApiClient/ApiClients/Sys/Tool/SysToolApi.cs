
using AmperaHome.WebApiClient.ApiClients.Sys.Tool.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Sys.Tool;

public interface ISysToolApi
{
    Task<List<ToolsResponse>> GetToolList();
}

internal class SysToolApi(IAmperaHomeHttpClient _httpClient) : ISysToolApi
{
    public async Task<List<ToolsResponse>> GetToolList()
    {

        return (await _httpClient.GetFromJsonAsync<BaseResponse<List<ToolsResponse>>>("/app/sys/tool/list")).Data;
    }
}