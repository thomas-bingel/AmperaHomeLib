// See https://aka.ms/new-console-template for more information

namespace AmperaHome.WebApiClient.Models;


public interface IBaseResponse
{
    int ErrorCode { get; set; }
    string ErrorMessage { get; set; }
}

public class BaseResponse<T> : IBaseResponse
{
    [JsonPropertyName("data")]
    public T Data { get; set; } = default!;


    [JsonPropertyName("errCode")]
    public int ErrorCode { get; set; } = default!;


    [JsonPropertyName("errMsg")]
    public string ErrorMessage { get; set; } = default!;
}
