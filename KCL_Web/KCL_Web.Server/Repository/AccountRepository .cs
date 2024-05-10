using System.Text.RegularExpressions;
using KCL_Web.Server.Dtos.Account;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly KclinicKclWebsiteContext _context;

        public AccountRepository(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        public async Task<Account?> DeleteByEmailAsync(string email)
        {
            var accountToDelete = await _context.Accounts.FirstOrDefaultAsync(a => a.Email == email);
            if (accountToDelete == null)
            {
                return null; // Không tìm thấy tài khoản
            }

            _context.Accounts.Remove(accountToDelete);
            await _context.SaveChangesAsync();

            return accountToDelete;
        }

        public async Task<List<Account>> GetAllAsync()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task<Account?> GetByEmailAsync(string email)
        {
            return await _context.Accounts.FirstOrDefaultAsync(a => a.Email == email);
        }

        public async Task<Account?> GetByIdAsync(int id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return await _context.Accounts.AllAsync(a => a.Email != email);
        }

        public async Task<bool> ResetPasswordAsync(string email, string newPassword)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Email == email);
            if (account == null)
            {
                return false;
            }
            account.Password = newPassword;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ChangePasswordAsync(int id, string newPassword)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return false;
            }
            account.Password = newPassword;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ValidateCredentialsAsync(string email, string password)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Email == email && a.Password == password);
            return account != null;
        }

        public async Task<Account?> UpdateAsync(int id, Account accountModel)
        {
            var existingAccount = await _context.Accounts.FindAsync(id);
            if (existingAccount == null)
            {
                return null;
            }
            existingAccount.Email = accountModel.Email;
            existingAccount.Password = accountModel.Password;
            existingAccount.Active = accountModel.Active;
            existingAccount.CreatedDate = accountModel.CreatedDate;
            // Update other properties as needed
            await _context.SaveChangesAsync();
            return existingAccount;
        }

        public async Task<Account> CreateAsync(Account accountModel)
        {
            await _context.Accounts.AddAsync(accountModel);
            await _context.SaveChangesAsync();
            return accountModel;
        }

        public Task<bool> IsValidEmail(string email)
        {
            // Kiểm tra xem địa chỉ email có null hoặc rỗng không
            if (string.IsNullOrEmpty(email))
            {
                return Task.FromResult(false);
            }

            try
            {
                // Sử dụng biểu thức chính quy để kiểm tra định dạng của email
                var emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return Task.FromResult(emailRegex.IsMatch(email));
            }
            catch (RegexMatchTimeoutException)
            {
                // Nếu quá trình kiểm tra mất quá nhiều thời gian, trả về false
                return Task.FromResult(false);
            }
        }
    }
}