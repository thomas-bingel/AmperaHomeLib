using System.Security.Cryptography;

namespace AmperaHome.WebApiClient.Utils;

internal static class EncryptUtils
{
    internal static string EncryptMD5ToString(string data)
    {
        var dataBytes = Encoding.UTF8.GetBytes(data);
        var dataHashBytes = MD5.HashData(dataBytes);
        var hashString = Convert.ToHexString(dataHashBytes);
        return hashString;
    }

    internal static string EncryptRSA2Base64(byte[] passwordBytes, byte[] publicKeyBytes, int v1, string v2)
    {
        var rsa = new RSACryptoServiceProvider();
        rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);

        var rsaParams = rsa.ExportParameters(false);
        var exponent = rsaParams.Exponent;
        var modulus = rsaParams.Modulus;

        //Encrypt the password and encode 64
        var encryptedPassword = Convert.ToBase64String(rsa.Encrypt(passwordBytes, RSAEncryptionPadding.Pkcs1));
        return encryptedPassword;
    }

    internal static string EncryptSHA1ToString(string data)
    {
        var dataBytes = Encoding.UTF8.GetBytes(data);
        var dataHashBytes = SHA1.HashData(dataBytes);
        var hashString = Convert.ToHexString(dataHashBytes);
        return hashString;

    }
}
