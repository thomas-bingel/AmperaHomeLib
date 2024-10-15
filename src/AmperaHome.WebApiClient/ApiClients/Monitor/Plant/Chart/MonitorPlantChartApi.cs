using AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart;

public interface IMonitorPlantChartApi
{
    Task<BatteryChargeEnergyData> GetBatteryChargeEnergyData(string plantUid, string chartDateType, string deviceSn, string? chartDay = null, string? chartWeekStartDay = null, string? chartWeekEndDay = null, string? chartMonth = null, string? chartYear = null);
    Task<ChartSettingsListResponse[]> GetChartSettingsList();
    Task<SelfUseEnergyModel> GetSelfUseEnergyDataByDay(DateTime? date = null);
    Task<SelfUseEnergyModel> GetSelfUseEnergyDataByMonth(string plantUid, string deviceSn, int month, int year);
    Task<SelfUseEnergyModel> GetSelfUseEnergyDataByTotal(string plantUid, string deviceSn);
    Task<SelfUseEnergyModel> GetSelfUseEnergyDataByYear(string plantUid, string deviceSn, string year);
    Task<ChartMultiDataModel> GetStorePowerAnalysisData(string deviceSn, DateTime chartDay);
}
internal class MonitorPlantChartApi(string _plantUid, IAmperaHomeHttpClient _httpClient) : IMonitorPlantChartApi
{

    public async Task<ChartSettingsListResponse[]> GetChartSettingsList()
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "plantUid", _plantUid },
        };
        return (await _httpClient.GetFromJsonAsync<BaseResponse<ChartSettingsListResponse[]>>(
            "/app/monitor/plant/chart/chartSettingsList",
            testRequestMap)).Data;
    }
  



    public async Task<SelfUseEnergyModel> GetSelfUseEnergyDataByDay(DateTime? date = null) => await GetSelfUseEnergyData(
            _plantUid,
            "1",
            null,
            (date ?? DateTime.Now).ToString("yyyy-MM-dd"),
            null,
            null,
            null,
            null);

    public async Task<SelfUseEnergyModel> GetSelfUseEnergyDataByWeek(
        string plantUid,
        string deviceSn,
        DateTime startDate) => await GetSelfUseEnergyData(
            plantUid,
            "2",
            deviceSn,
            null,
            startDate.ToString("yyyy-MM-dd"),
            startDate.AddDays(6).ToString("yyyy-MM-dd"),
            null,
            null);

    public async Task<SelfUseEnergyModel> GetSelfUseEnergyDataByMonth(
        string plantUid,
        string deviceSn,
        int month,
        int year)
    {
        return await GetSelfUseEnergyData(
            plantUid,
            "3",
            deviceSn,
            null,
            null,
            null,
            string.Format("{0:D4}-{1:D2}", year, month),
            null);
    }

    public async Task<SelfUseEnergyModel> GetSelfUseEnergyDataByYear(
        string plantUid,
        string deviceSn,
        string year)
    {
        return await GetSelfUseEnergyData(
            plantUid,
            "4",
            deviceSn,
            null,
            null,
            null,
            null,
            year);
    }

    public async Task<SelfUseEnergyModel> GetSelfUseEnergyDataByTotal(
        string plantUid,
        string deviceSn
    )
    {
        return await GetSelfUseEnergyData(
            plantUid,
            "5",
            deviceSn,
            null,
            null,
            null,
            null,
            null);
    }



    private async Task<SelfUseEnergyModel> GetSelfUseEnergyData(
        string plantUid,
        string chartDateType,
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
            { "plantUid", plantUid },
            { "chartDateType", chartDateType },
        };

        if (!string.IsNullOrEmpty(chartDay))
            testRequestMap.Add("chartDay", chartDay);
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



    public async Task<BatteryChargeEnergyData> GetBatteryChargeEnergyDataByDay(
        string plantUid,
        string deviceSn,
        DateTime date)
    {
        return await GetBatteryChargeEnergyData(
            plantUid,
            "1",
            deviceSn,
            date.ToString("yyyy-MM-dd"),
            null,
            null,
            null,
            null);
    }

    public async Task<BatteryChargeEnergyData> GetBatteryChargeEnergyData(
        string plantUid,
        string chartDateType,
        string deviceSn,
        string? chartDay = null,
        string? chartWeekStartDay = null,
        string? chartWeekEndDay = null,
        string? chartMonth = null,
        string? chartYear = null)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "plantUid", plantUid },
            { "chartDateType", chartDateType },
            { "deviceSn", deviceSn },
        };

        if (!string.IsNullOrEmpty(chartDay))
            testRequestMap.Add("chartDay", chartDay);
        if (!string.IsNullOrEmpty(chartWeekStartDay))
            testRequestMap.Add("chartWeekStartDay", chartWeekStartDay);
        if (!string.IsNullOrEmpty(chartWeekEndDay))
            testRequestMap.Add("chartWeekEndDay", chartWeekEndDay);
        if (!string.IsNullOrEmpty(chartMonth))
            testRequestMap.Add("chartMonth", chartMonth);
        if (!string.IsNullOrEmpty(chartYear))
            testRequestMap.Add("chartYear", chartYear);

        testRequestMap.RemoveNullValues();

        return (await _httpClient.GetFromJsonAsync<BaseResponse<BatteryChargeEnergyData>>(
            "/app/monitor/plant/chart/getBatteryChargeEnergyData",
            testRequestMap)).Data;
    }




    public async Task<ChartMultiDataModel> GetGridCurveAnalysisData(
        string plantUid,
        string deviceSn,
        DateTime chartDay)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "chartDateType", "1" }, // This should not be set...

            { "plantUid", plantUid },
            { "chartDay", chartDay.ToString("yyyy-MM-dd") },
            { "deviceSn", deviceSn },
        };

        testRequestMap.RemoveNullValues();

        
        return (await _httpClient.GetFromJsonAsync<BaseResponse<ChartMultiDataModel>>(
            "/app/monitor/plant/chart/getGridCurveAnalysisData",
            testRequestMap)).Data;
    }




    public async Task<ChartMultiDataModel> GetStorePowerAnalysisData(
        string deviceSn,
        DateTime chartDay)
    {
        var testRequestMap = new Dictionary<string, string>
        {
            { "plantUid", _plantUid },
            { "chartDay", chartDay.ToString("yyyy-MM-dd") },
            { "deviceSn", deviceSn },
        };

        testRequestMap.RemoveNullValues();

        return (await _httpClient.GetFromJsonAsync<BaseResponse<ChartMultiDataModel>>(
            "/app/monitor/plant/chart/getStorePowerAnalysisData",
            testRequestMap)).Data;
    }


}