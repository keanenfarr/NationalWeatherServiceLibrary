using System.Collections.Specialized;
using System.Threading.Tasks;

namespace NWS.WebClient
{
    public interface IWebClient
    {

        Task<string> GetAsync(string url);
    }
}
