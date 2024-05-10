namespace KCL_Web.Server.Dtos.Account
{
    public class CreateAccountRequestDto
    {
        public string? Email { get; set; } = null!;

        public string? Password { get; set; } = null!;

        public string? Name { get; set; }
    }
}