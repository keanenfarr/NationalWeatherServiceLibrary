using System.Collections.Specialized;

namespace NWS.WebClient
{
    public interface IWebClient
    {
        byte[] Get(string url);

        byte[] Post(string url, NameValueCollection postData);
    }
}
