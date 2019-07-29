using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace NWS.WebClient.Default
{
    public class WebClient : IWebClient
    {
        const string userAgent = "NWS Weather Library for DotNet - https://github.com/keanenfarr/NationalWeatherServiceLibrary";

        public byte[] Get(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("accept", "application/json");
                client.Headers.Add("user-agent", userAgent);
                return client.DownloadData(new System.Uri(url));
            }
        }

        public async Task<byte[]> GetAsync(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("accept", "application/json");
                client.Headers.Add("user-agent", userAgent);
                return await client.DownloadDataTaskAsync(new System.Uri(url));
            }
        }

        public byte[] Post(string url, NameValueCollection postData)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("accept", "application/json");
                client.Headers.Add("Content-type", "application/x-www-form-urlencoded");
                client.Headers.Add("accept-encoding", "gzip, deflate, br");
                client.Headers.Add("user-agent", userAgent);
                var response = client.UploadValues(new System.Uri(url), "POST", postData);

                return response;
            }
        }
    }
}
