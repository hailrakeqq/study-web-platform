using study_web_platform.Entities;

namespace study_web_platform.Models
{
    public class AuthenticateResponce
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthenticateResponce(User user, string token)
        {
            Id = user.Id;
            Username = user?.Username;
            Email = user?.Email;
            Token = token;
        }
    }
}

