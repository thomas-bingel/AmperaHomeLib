namespace AmperaHome.WebApiClient.Utils;

internal static class Helper
{
    private readonly static string SIGNATURE = "signature";
    private readonly static string SIGN_PARAMS = "signParams";

    public static Dictionary<string, string> ToEncodeMap(Dictionary<string, string> paramMap, string key)
    {
        paramMap.Remove(SIGN_PARAMS);
        paramMap.Remove(SIGNATURE);

        paramMap.TryAdd("timeStamp", DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString());
        paramMap.TryAdd("clientId", "esolar-app");


        int i = paramMap.Count;
        while (i < 5)
        {
            paramMap.Add("trimParam" + i, "trimParam" + i);
            i++;
        }

        var array = paramMap.Keys.ToArray();
        Array.Sort(array);

        var sb = new StringBuilder();
        var sb2 = new StringBuilder();

        foreach (var obj in array)
        {
            if (sb.Length > 0)
            {
                sb.Append('&');
            }

            if (sb2.Length > 0)
            {
                sb2.Append(',');
            }

            sb.Append(obj);
            sb.Append('=');
            sb.Append(paramMap[obj].ToString().Trim());
            sb2.Append(obj);
        }

        sb.Append("&key=");
        sb.Append(key);

        var md5HashString = EncryptUtils.EncryptMD5ToString(sb.ToString()).ToLower();
        var sha1 = EncryptUtils.EncryptSHA1ToString(md5HashString).ToUpper();

        paramMap.Add(SIGNATURE, sha1);

        paramMap.Add(SIGN_PARAMS, sb2.ToString());
        return paramMap;
    }
}
