namespace AmperaHome.WebApiClient.Models;

public class BaseList<T>
{
    [JsonPropertyName("endRow")]
    public int EndRow { get; set; } = default!;

    [JsonPropertyName("hasNextPage")]
    public bool HasNextPage { get; set; } = default!;

    [JsonPropertyName("hasPreviousPage")]
    public bool HasPreviousPage { get; set; } = default!;

    [JsonPropertyName("isFirstPage")]
    public bool IsFirstPage { get; set; } = default!;

    [JsonPropertyName("isLastPage")]
    public bool IsLastPage { get; set; } = default!;

    [JsonPropertyName("list")]
    public List<T> List { get; set; } = default!;
    public int navigateFirstPage { get; set; } = default!;
    public int navigateLastPage { get; set; } = default!;
    public int navigatePages { get; set; } = default!;
    public List<int> navigatepageNums { get; set; } = default!;
    public int nextPage { get; set; } = default!;
    public int pageNum { get; set; } = default!;
    public int pageSize { get; set; } = default!;
    public int pages { get; set; } = default!;
    public int prePage { get; set; } = default!;
    public int size { get; set; } = default!;

    [JsonPropertyName("startRow")] 
    public int StartRow { get; set; } = default!;

    [JsonPropertyName("total")]
    public int Total { get; set; } = default!;
}
