using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiServer.Model.DTO;

public class CreateAccountDTO
{
    [Required, EmailAddress]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email must consist of letters and numbers only.")]
    public string Email { get; set; }

    [Required, MinLength(8), MaxLength(12)]
    [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Password must contain only letters and numbers.")]
    public string Password { get; set; }
}
