using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Net.Http.Headers;

namespace NWS.WebClient.Default
{
    public class WebClient : IWebClient
    {
        protected static HttpClient HttpClient = new HttpClient();
        private static bool isInitialized = false;

        public WebClient()
        {
            if (!isInitialized)
            {
                HttpClient.Timeout = new TimeSpan(0, 0, 30);
                HttpClient.DefaultRequestHeaders.Clear();
                HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("NWSWeatherLibraryForDotNet/1.0");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                isInitialized = true;
            }
        }

        public byte[] Get(string url)
        {
            return HttpClient.GetByteArrayAsync(url).Result;
        }

        public async Task<byte[]> GetAsync(string url)
        {
            var response = await HttpClient.GetAsync(url);
            
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
