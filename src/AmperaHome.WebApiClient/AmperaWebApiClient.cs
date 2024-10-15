using AmperaHome.WebApiClient.ApiClients.Monitor;
using AmperaHome.WebApiClient.ApiClients.Sys;

namespace AmperaHome.WebApiClient;

public class AmperaWebApiClient(
    IMonitorApi _monitorApi,
    ISysApi _sysApi)
{
    public IMonitorApi Monitor { get; protected set; } = _monitorApi;
    public ISysApi Sys { get; protected set; } = _sysApi;
}
