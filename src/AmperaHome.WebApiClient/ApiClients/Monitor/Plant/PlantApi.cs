using AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart;
using AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant;


public interface IPlantApi
{
    Task<GetPlantDetailResponse> Details();

    IMonitorPlantChartApi Chart { get; }
}

internal class PlantApi(string _plantUid, IAmperaHomeHttpClient _httpClient) : IPlantApi
{

    public IMonitorPlantChartApi Chart { get; } = new MonitorPlantChartApi(_plantUid, _httpClient);

    public async Task<GetPlantDetailResponse> Details()
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "plantUid", _plantUid },
        };
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetPlantDetailResponse>>(
            "/app/monitor/plant/getManagementPlantInfo",
            testRequestMap)).Data;
    }

}