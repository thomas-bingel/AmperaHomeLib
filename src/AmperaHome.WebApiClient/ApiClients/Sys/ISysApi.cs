using AmperaHome.WebApiClient.ApiClients.Sys.Settings;
using AmperaHome.WebApiClient.ApiClients.Sys.Tool;
using AmperaHome.WebApiClient.ApiClients.Sys.User;

namespace AmperaHome.WebApiClient.ApiClients.Sys;

public interface ISysApi
{
    ISysSettingsApi SettingsApi { get; }
    ISysUserApi User { get; }
    ISysToolApi SysToolApi { get; }
}

internal class SysApi(ISysSettingsApi _settingsApi, ISysUserApi _userApi, ISysToolApi _sysToolApi
    ) : ISysApi
{
    public ISysSettingsApi SettingsApi { get; } = _settingsApi;
    public ISysUserApi User { get; } = _userApi;
    public ISysToolApi SysToolApi { get; } = _sysToolApi;

}