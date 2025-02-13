using System.Net;

namespace helptp.Extensions;

public static class IntExtensions
{
    public static string GetHttpStatusName(this int statusCode)
    {
        return Enum.GetName(typeof(HttpStatusCode), statusCode) != null 
            ? ((HttpStatusCode)statusCode).ToString() 
            : "The entered status code was out of range.";
    }
}