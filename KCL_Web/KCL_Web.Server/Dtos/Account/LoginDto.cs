using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Dtos.Account
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


    }
}