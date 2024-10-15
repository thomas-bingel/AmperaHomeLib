using AmperaHome.WebApiClient.ApiClients.Monitor;
using AmperaHome.WebApiClient.ApiClients.Monitor.Battery;
using AmperaHome.WebApiClient.ApiClients.Monitor.Device;
using AmperaHome.WebApiClient.ApiClients.Monitor.Home;
using AmperaHome.WebApiClient.ApiClients.Monitor.Plant;
using AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart;
using AmperaHome.WebApiClient.ApiClients.Monitor.PlantAchievements;
using AmperaHome.WebApiClient.ApiClients.Sys;
using AmperaHome.WebApiClient.ApiClients.Sys.Settings;
using AmperaHome.WebApiClient.ApiClients.Sys.Tool;
using AmperaHome.WebApiClient.ApiClients.Sys.User;
using AmperaHome.WebApiClient.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AmperaHome.WebApiClient;

public static class AmperaHomeServiceCollectionExtensions
{
    public static IServiceCollection AddAmperaHome(this IServiceCollection services, Action<AmperaHomeWebApiOptions> configure = default!)
    {
        ArgumentNullException.ThrowIfNull(services);

        var options = new AmperaHomeWebApiOptions();

        if (configure != null) { 
            services.Configure(configure);
            configure(options);
        }

        services.AddHttpClient(HttpClientNames.AmperaHomeWebApiClient, httpClientConfigure =>
        {
            if (options.AmperaHomeBaseUrl is null)
                throw new AmeraHomeException(nameof(options.AmperaHomeBaseUrl) + " is null");

            httpClientConfigure.BaseAddress = new Uri(options.AmperaHomeBaseUrl);
        });

        services.AddHttpClient();
        services.AddSingleton<AmperaWebApiClient>();
        services.AddSingleton<IPublicKeyProvider, PublicKeyProvider>();
        services.AddSingleton<IAccessTokenProvider, AccessTokenProvider>();
        services.AddSingleton<IAmperaHomeHttpClient, AmperaHomeHttpClient>();

        services.AddSingleton<IMonitorApi, MonitorApi>();
        services.AddSingleton<IMonitorBatteriesApi, MonitorBatteriesApi>();
        services.AddSingleton<IMonitorDevicesApi, MonitorDevicesApi>();
        services.AddSingleton<IMonitorHomeApi, MonitorHomeApi>();
        services.AddSingleton<IMonitorPlantsApi, MonitorPlantsApi>();
        services.AddSingleton<IMonitorPlantChartApi, MonitorPlantChartApi>();
        services.AddSingleton<IMonitorPlantAchievementsApi, MonitorPlantAchievementsApi>();

        services.AddSingleton<ISysApi, SysApi>();
        services.AddSingleton<ISysUserApi, SysUserApi>();
        services.AddSingleton<ISysToolApi, SysToolApi>();
        services.AddSingleton<ISysSettingsApi, SysSettingsApi>();

        return services;
    }
}
