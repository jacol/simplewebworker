using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleWebWorker
{
    public class WebCaller
    {
        public Task<string> GetContent(string url)
        {
            using(var httpClient = new HttpClient())
            {
                return httpClient.GetStringAsync(url);
            }
        }
    }
}