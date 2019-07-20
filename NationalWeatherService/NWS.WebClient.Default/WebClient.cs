using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace NWS.WebClient.Default
{
    public class WebClient : IWebClient
    {
        public byte[] Get(string url)
        {
            byte[] buffer = new byte[4096];
            byte[] requestBuffer = new byte[0];

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AllowAutoRedirect = true;
            request.Method = "GET";
            request.UserAgent = "NWS Weather Library for DotNet - https://github.com/keanenfarr/NationalWeatherServiceLibrary";
            request.Accept = "application/json";
            request.ContentType = "application/json";
            request.ContentLength = requestBuffer.Length;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var dataStream = response.GetResponseStream())
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        int count = 0;
                        do
                        {
                            count = dataStream.Read(buffer, 0, buffer.Length);
                            memoryStream.Write(buffer, 0, count);

                        } while (count != 0);

                        return memoryStream.ToArray();
                    }
                }
            }
        }

        public byte[] Post(string url, NameValueCollection postData)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("accept", "application/json");
                client.Headers.Add("Content-type", "application/x-www-form-urlencoded");
                client.Headers.Add("accept-encoding", "gzip, deflate, br");
                client.Headers.Add("user-agent", "NWS Weather Library for DotNet - https://github.com/keanenfarr/NationalWeatherServiceLibrary");
                client.Headers.Add("accept-language", "en-US,en;q=0.9");
                var response = client.UploadValues(new System.Uri(url), "POST", postData);

                return response;
            }
        }
    }
}
