using KCL_Web.Server.Dtos.Role;

namespace KCL_Web.Server.Dtos.Account
{
    public class AccountDto
    {
        public int AccountId { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public byte? Active { get; set; } = 0;

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public string? Name { get; set; }
        public int? RoleId { get; set; }
    }
}