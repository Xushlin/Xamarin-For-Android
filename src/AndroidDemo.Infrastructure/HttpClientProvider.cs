using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AndroidDemo.Infrastructure
{
    public class HttpClientProvider<T>
    {
        public async Task<T> GetAsync(string url)
        {
            var jsonString = await HttpClientUnitty.Of().GetStringAsync(url);
            return string.IsNullOrEmpty(jsonString) ? default(T) : JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}