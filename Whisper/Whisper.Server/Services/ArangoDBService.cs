using Core.Arango;

namespace Whisper.Server.Services
{
    public class ArangoDBService
    {
        private readonly IArangoContext _arangoContext;

        public ArangoDBService(IConfiguration configuration)
        {
            _arangoContext = new ArangoContext(
                new ArangoConfiguration
                {
                    Server = new ArangoServer
                    {
                        Endpoint = configuration["ArangoDB:Url"],
                        Database = configuration["ArangoDB:Database"],
                        Username = configuration["ArangoDB:Username"],
                        Password = configuration["ArangoDB:Password"]
                    }
                });
        }

        public IArangoContext GetContext() => _arangoContext;
    }
}
