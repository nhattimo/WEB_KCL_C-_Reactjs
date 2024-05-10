using KCL_Web.Server.Dtos.Account;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAsync();
        Task<Account?> GetByEmailAsync(string email); // Lấy tài khoản bằng email
        Task<Account> CreateAsync(Account accountModel); // Tạo mới một tài khoản
        Task<Account?> UpdateAsync(int id, Account accountModel); // Cập nhật thông tin của một tài khoản
        Task<Account?> DeleteByEmailAsync(string email); // Xóa một tài khoản
        Task<bool> ValidateCredentialsAsync(string email, string password); // Xác thực thông tin đăng nhập
        Task<bool> ChangePasswordAsync(int id, string newPassword); // Thay đổi mật khẩu của tài khoản
        Task<bool> ResetPasswordAsync(string email, string newPassword); // Đặt lại mật khẩu của tài khoản
        Task<bool> IsEmailUniqueAsync(string email); // Kiểm tra xem email có duy nhất không
        Task<bool> IsValidEmail(string email);
    }
}