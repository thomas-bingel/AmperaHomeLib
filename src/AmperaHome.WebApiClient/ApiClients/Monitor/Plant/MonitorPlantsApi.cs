using AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant;

public interface IMonitorPlantsApi
{
    IPlantApi this[string plantId] { get; }
    
    Task<GetPlantListResponse> List();
}
internal class MonitorPlantsApi(IAmperaHomeHttpClient _httpClient) : IMonitorPlantsApi
{

    public IPlantApi this[string plantId] => new PlantApi(plantId, _httpClient);

    public async Task<GetPlantListResponse> List()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetPlantListResponse>>(
            "/app/monitor/plant/getPlantList")).Data;
    }

}