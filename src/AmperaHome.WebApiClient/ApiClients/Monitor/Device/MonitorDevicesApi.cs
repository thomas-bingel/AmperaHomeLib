using AmperaHome.WebApiClient.ApiClients.Monitor.Device.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Device;

public interface IMonitorDevicesApi
{
    IMonitorDeviceApi this[string index] { get; }

    Task<GetInverterListResponse> List();
}
internal class MonitorDevicesApi(IAmperaHomeHttpClient _httpClient) : IMonitorDevicesApi
{

    public IMonitorDeviceApi this[string index] => new MonitorDeviceApi(index, _httpClient);

    public async Task<GetInverterListResponse> List()
    {

        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetInverterListResponse>>(
            "/app/monitor/device/getDeviceList")).Data;
    }


}