

using AmperaHome.WebApiClient.ApiClients.Monitor.PlantAchievements.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.PlantAchievements;

public interface IMonitorPlantAchievementsApi
{
}
internal class MonitorPlantAchievementsApi(IAmperaHomeHttpClient _httpClient) : IMonitorPlantAchievementsApi
{
    public async Task<GetAchievementResponse> GetPlantAchievement(string plantUid)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "plantUid", plantUid },
        };
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetAchievementResponse>>(
            "/app/monitor/plantAchievements/getPlantAchievements",
            testRequestMap)).Data;
    }


}