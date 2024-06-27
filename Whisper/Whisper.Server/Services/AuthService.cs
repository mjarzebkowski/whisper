using BCrypt.Net;
using Core.Arango.Protocol;
using System.Threading.Tasks;
using Whisper.Data;

namespace Whisper.Server.Services
{
    public class AuthService
    {
        private readonly ArangoDBService _arangoDBService;

        public AuthService(ArangoDBService arangoDBService)
        {
            _arangoDBService = arangoDBService;
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
    }
}
