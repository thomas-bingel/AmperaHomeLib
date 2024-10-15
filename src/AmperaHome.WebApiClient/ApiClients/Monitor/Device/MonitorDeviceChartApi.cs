using AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Device;

public interface IMonitorDeviceChartApi
{
    Task<SelfUseEnergyModel> GetSelfUseEnergyDataByDay(DateTime? date = null);
}

public class MonitorDeviceChartApi(string _deviceSn, IAmperaHomeHttpClient _httpClient) : IMonitorDeviceChartApi
{
    public async Task<SelfUseEnergyModel> GetSelfUseEnergyDataByDay(DateTime? date = null) => await GetSelfUseEnergyData(
            "1",
            null,
            _deviceSn,
            (date ?? DateTime.Now).ToString("yyyy-MM-dd"),
            null,
            null,
            null,
            null);
    private async Task<SelfUseEnergyModel> GetSelfUseEnergyData(
        string chartDateType,
        string? plantUid = null,
        string? deviceSn = null,
        string? chartDay = null,
        string? chartWeekStartDay = null,
        string? chartWeekEndDay = null,
        string? chartMonth = null,
        string? chartYear = null)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "clientDate", DateTime.Now.ToString("yyyy-MM-dd") },
            { "chartDateType", chartDateType },
        };

        if (!string.IsNullOrEmpty(chartDay))
            testRequestMap.Add("chartDay", chartDay);
        if (!string.IsNullOrEmpty(plantUid))
            testRequestMap.Add("plantUid", plantUid);
        if (!string.IsNullOrEmpty(deviceSn))
            testRequestMap.Add("deviceSn", deviceSn);
        if (!string.IsNullOrEmpty(chartWeekStartDay))
            testRequestMap.Add("chartWeekStartDay", chartWeekStartDay);
        if (!string.IsNullOrEmpty(chartWeekEndDay))
            testRequestMap.Add("chartWeekEndDay", chartWeekEndDay);
        if (!string.IsNullOrEmpty(chartMonth))
            testRequestMap.Add("chartMonth", chartMonth);
        if (!string.IsNullOrEmpty(chartYear))
            testRequestMap.Add("chartYear", chartYear);

        testRequestMap.RemoveNullValues();

        return (await _httpClient.GetFromJsonAsync<BaseResponse<SelfUseEnergyModel>>(
            "/app/monitor/plant/chart/getSelfUseEnergyData",
            testRequestMap)).Data;
    }

}