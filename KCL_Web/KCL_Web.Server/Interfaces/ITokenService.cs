using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(Account user);
    }
}