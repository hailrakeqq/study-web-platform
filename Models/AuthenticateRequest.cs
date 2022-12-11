using System.ComponentModel.DataAnnotations;
namespace study_web_platform.Models
{

    public class AuthenticateRequest
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}