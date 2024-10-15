using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Device;

public interface IMonitorDeviceApi
{
    IMonitorDeviceChartApi Chart { get; }

}

internal class MonitorDeviceApi(string _deviceSn, IAmperaHomeHttpClient _httpClient) : IMonitorDeviceApi
{

    public IMonitorDeviceChartApi Chart { get; } = new MonitorDeviceChartApi(_deviceSn, _httpClient);
}