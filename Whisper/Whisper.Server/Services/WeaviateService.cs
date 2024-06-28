using WeaviateNET;

namespace Whisper.Server.Services
{
    public class WeaviateService
    {
        private readonly WeaviateClient _client;

        public WeaviateService(HttpClient httpClient)
        {
            var config = new WeaviateClientConfig { BaseUrl = "your-base-url" };
            _client = new WeaviateClient(config, httpClient);
        }

        public async Task<object> GetDataAsync()
        {
            var data = await _client.Data.GetAsync();
            return data;
        }
    }
}
