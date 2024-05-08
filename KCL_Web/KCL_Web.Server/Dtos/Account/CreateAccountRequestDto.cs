namespace KCL_Web.Server.Dtos.Account
{
    public class CreateAccountRequestDto
    {
        public string? Email { get; set; } = null!;

        public string? Password { get; set; } = null!;

        public byte? Active { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? RoleId { get; set; }

        public string? Name { get; set; }
    }
}