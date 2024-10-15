
using AmperaHome.WebApiClient.ApiClients.Sys.Settings.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Sys.Settings;

public interface ISysSettingsApi
{
    Task<GetSettingInfoResponse> GetSettingsInfo();
}

internal class SysSettingsApi(IAmperaHomeHttpClient _httpClient) : ISysSettingsApi
{
    public async Task<GetSettingInfoResponse> GetSettingsInfo()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<GetSettingInfoResponse>>(
            "/app/sys/settings/getInfo")).Data;
    }

}