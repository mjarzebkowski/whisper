using WeaviateNET;

namespace Whisper.Server.Services
{
    public class WeaviateService
    {
        private readonly WeaviateClient _client;

        public WeaviateService()
        {
            var config = new WeaviateCliententConfig
            {
                Scheme = "http",
                Host = "localhost:8080"
            };
            _client = new WeaviateClient(config);
        }

        public async Task<List<WeaviateObject>> GetObjectsAsync()
        {
            var result = await _client.Data.GetAsync();
            return result.Objects;
        }

        // Dodaj inne metody do interakcji z Weaviate
    }
}
