namespace AmperaHome.WebApiClient.Http;

public class AmeraHomeException : Exception
{
    public AmeraHomeException()
    {
    }

    public AmeraHomeException(string? message) : base(message)
    {
    }

    public AmeraHomeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}