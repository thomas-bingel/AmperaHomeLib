using AmperaHome.WebApiClient.ApiClients.Monitor.Battery.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Battery;

public interface IMonitorBatteriesApi
{
    IMonitorBatteryApi this[string deviceSn] { get; }

    Task<GetBatteryListResponse> List();
}
internal class MonitorBatteriesApi(IAmperaHomeHttpClient _httpClient) : IMonitorBatteriesApi
{

    public IMonitorBatteryApi this[string index] => new MonitorBatteryApi(index, _httpClient);

    public async Task<GetBatteryListResponse> List()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetBatteryListResponse>>(
            "/app/monitor/battery/getBatteryList")).Data;
    }
}