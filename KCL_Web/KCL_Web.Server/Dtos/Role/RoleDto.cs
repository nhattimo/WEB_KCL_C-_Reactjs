using KCL_Web.Server.Dtos.Account;

namespace KCL_Web.Server.Dtos.Role
{
    public class RoleDto
    {
        public int RoleId { get; set; }

        public string? RoleName { get; set; }

        public string? RoleDescription { get; set; }

        //public List<AccountDto> Accounts { get; set; }
    }
}