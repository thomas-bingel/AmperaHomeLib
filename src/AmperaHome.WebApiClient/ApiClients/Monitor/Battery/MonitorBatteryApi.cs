using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Battery;

public interface IMonitorBatteryApi
{
}

public class MonitorBatteryApi(string index, IAmperaHomeHttpClient httpClient) : IMonitorBatteryApi
{
    // Add methods for single battery
}