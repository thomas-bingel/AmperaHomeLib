namespace AmperaHome.WebApiClient.Utils;

internal static class DictionaryExtensions
{
    public static void RemoveNullValues(
        this Dictionary<string, string> dictionary)
    {
        foreach (var key in dictionary.Where(x => x.Value == null).Select(_ => _.Key))
            dictionary.Remove(key);
    }
}
