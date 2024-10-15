
using AmperaHome.WebApiClient.ApiClients.Sys.User.Models;
using AmperaHome.WebApiClient.Http;

namespace AmperaHome.WebApiClient.ApiClients.Sys.User;

public interface ISysUserApi
{
    Task<UserInfoResponse> GetUserInfo();
}

internal class SysUserApi(IAmperaHomeHttpClient _httpClient) : ISysUserApi
{
    public async Task<UserInfoResponse> GetUserInfo()
    {
        return (await _httpClient.GetFromJsonAsync<BaseResponse<UserInfoResponse>>(
            "/app/sys/user/getInfo")).Data;
    }

}