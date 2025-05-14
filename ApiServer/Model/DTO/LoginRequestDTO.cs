using System.ComponentModel.DataAnnotations;

namespace ApiServer.Model.DTO
{
    public class LoginRequestDTO
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(8), MaxLength(12)]
        public string Password { get; set; }
    }
}
