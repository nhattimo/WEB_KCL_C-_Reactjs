using Microsoft.AspNetCore.Identity;

namespace KCL_Web.Server.Models
{
    public class AppUser : IdentityUser
    {
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}