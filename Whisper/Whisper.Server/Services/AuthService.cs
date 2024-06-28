using Core.Arango;
using Microsoft.EntityFrameworkCore;
using Whisper.Shared.Data;

namespace Whisper.Server.Services
{
    public class AuthService
    {
        private readonly ArangoDBService _arangoDBService;
        private readonly IArangoContext _context;

        public AuthService(ArangoDBService arangoDBService, IArangoContext context)
        {
            _arangoDBService = arangoDBService;
            _context = context;
        }

        public async Task CreateDocumentAsync<T>(string collection, T document)
        {
            var database = _context.GetDatabase();
            var result = await _context.CreateAsync(database, collection, document);
        }

        public async Task Register(ApplicationUser user)
        {
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);

            var context = _arangoDBService.GetContext();
            await context.Document.CreateAsync("Users", user);
        }

        public async Task<bool> Login(string username, string password)
        {
            var context = _arangoDBService.GetContext();
            var users = await context.Query<ApplicationUser>("Users").Where(u => u.Username == username).ToListAsync();

            if (users.Count == 0)
                return false;

            var user = users[0];
            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }

        public async Task QueryAsync()
        {
            var query = _context.Query<string>().FirstOrDefault();
            if (query != null)
            {
                // handle query result
            }
        }
    }
}
