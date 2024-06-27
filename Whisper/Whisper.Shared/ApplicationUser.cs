namespace Whisper.Shared.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser
    {
        public string Key { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }

}
