using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleWebWorker
{
    public class WebCaller
    {
        public async Task<string> GetContent(string url)
        {
            using(var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }
    }
}