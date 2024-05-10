using KCL_Web.Server.Dtos.Account;
using KCL_Web.Server.Dtos.Role;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    public static class AccountMappers
    {
        public static AccountDto ToAccountDto(this Account account)
        {
            return new AccountDto
            {
                AccountId = account.AccountId,
                Email = account.Email,
                Password = account.Password,
                Active = account.Active,
                CreatedDate = account.CreatedDate,
                Name = account.Name,
                RoleId = account.RoleId
            };
        }

        public static Account ToAccountFromRegisterDto(this RegisterRequestDto registerDto, int roleId)
        {
            return new Account
            {
                Email = registerDto.Email,
                Password = registerDto.Password,
                Name = registerDto.Name,
                Active = 0,
                CreatedDate = DateTime.Now,
                RoleId = roleId
            };
        }

        public static Account ToAccountFromCreateDto(this CreateAccountRequestDto createDto)
        {
            return new Account
            {
                Email = createDto.Email,
                Password = createDto.Password,
                Name = createDto.Name
            };
        }
    }
}