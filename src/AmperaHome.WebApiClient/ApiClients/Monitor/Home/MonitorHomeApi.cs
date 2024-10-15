
using AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home;

public interface IMonitorHomeApi
{
    Task<GetHomeBatteryStatisticsDataResponse> GetBatteryStatisticsData();
    Task<GetDeviceFlowDataResponse> GetDeviceEnergyFlowData(string plantUid, string deviceSn);
    Task<GetHomeDeviceStatisticsDataResponse> GetDeviceStatisticsData();
    Task<GetHomeEneryStatisticsDataResponse> GetEneryStatisticsData();
    Task<GetHomePlantStatisticsDataResponse> GetPlantStatisticsData();
    Task<GetSinglePlantStatisticsDataResponse> GetPlantStatisticsData(string plantUid, string deviceSn);
}
internal class MonitorHomeApi(IAmperaHomeHttpClient _httpClient) : IMonitorHomeApi
{
    public async Task<GetHomeEneryStatisticsDataResponse> GetEneryStatisticsData()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetHomeEneryStatisticsDataResponse>>(
            "/app/monitor/home/getHomeEneryStatisticsData")).Data;
    }

    public async Task<GetHomePlantStatisticsDataResponse> GetPlantStatisticsData()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetHomePlantStatisticsDataResponse>>(
            "/app/monitor/home/getHomePlantStatisticsData")).Data;
    }
    public async Task<GetSinglePlantStatisticsDataResponse> GetPlantStatisticsData(
      string plantUid, string deviceSn)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "plantUid", plantUid },
            { "deviceSn", deviceSn },
        };

        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetSinglePlantStatisticsDataResponse>>(
            "/app/monitor/home/getPlantStatisticsData",
            testRequestMap)).Data;
    }

    public async Task<GetHomeDeviceStatisticsDataResponse> GetDeviceStatisticsData()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetHomeDeviceStatisticsDataResponse>>(
            "/app/monitor/home/getHomeDeviceStatisticsData")).Data;
    }

    public async Task<GetHomeBatteryStatisticsDataResponse> GetBatteryStatisticsData()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetHomeBatteryStatisticsDataResponse>>(
            "/app/monitor/home/getHomeBatteryStatisticsData")).Data;
    }

    public async Task<GetDeviceFlowDataResponse> GetDeviceEnergyFlowData(
        string plantUid, string deviceSn)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "platform", "Android" },
            { "plantUid", plantUid },
            { "deviceSn", deviceSn }, // not optional. Data is 0 if missing
        };

        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetDeviceFlowDataResponse>>(
            "/app/monitor/home/getDeviceEneryFlowData",
            testRequestMap)).Data;
    }


}