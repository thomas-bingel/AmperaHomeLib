using AmperaHome.WebApiClient.ApiClients.Monitor.Battery;
using AmperaHome.WebApiClient.ApiClients.Monitor.Device;
using AmperaHome.WebApiClient.ApiClients.Monitor.Home;
using AmperaHome.WebApiClient.ApiClients.Monitor.Plant;
using AmperaHome.WebApiClient.ApiClients.Monitor.PlantAchievements;

namespace AmperaHome.WebApiClient.ApiClients.Monitor;

public interface IMonitorApi
{
    

    IMonitorBatteriesApi Batteries { get; }
    IMonitorDevicesApi Devices { get; }
    IMonitorHomeApi Home { get; }
    IMonitorPlantsApi Plants { get; }

    IMonitorPlantAchievementsApi PlantAchievements { get; }
}

internal class MonitorApi(
    IMonitorBatteriesApi _batteryApi, 
    IMonitorDevicesApi _deviceApi, 
    IMonitorHomeApi _monitorHomeApi,
    IMonitorPlantsApi _monitorPlantApi,
    IMonitorPlantAchievementsApi _monitorPlantAchievementsApi
    ) : IMonitorApi
{
    public IMonitorBatteriesApi Batteries { get; } = _batteryApi;
    public IMonitorDevicesApi Devices { get; } = _deviceApi;
    public IMonitorHomeApi Home { get; } = _monitorHomeApi;
    public IMonitorPlantsApi Plants { get; } = _monitorPlantApi;
    public IMonitorPlantAchievementsApi PlantAchievements { get; } = _monitorPlantAchievementsApi;

}