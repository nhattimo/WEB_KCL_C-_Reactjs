namespace KCL_Web.Server.Dtos.Account
{
    public class UpdateAccountRequestDto
    {
        // Các thuộc tính mà người dùng có thể cập nhật
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        // Các thuộc tính khác nếu cần thiết
    }
}