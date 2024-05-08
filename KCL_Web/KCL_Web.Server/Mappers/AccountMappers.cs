using KCL_Web.Server.Dtos.Account;
using KCL_Web.Server.Dtos.Role;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    public static class AccountMappers
    {
        public static AccountDto ToAccountDto(this Account accountModel)
        {
            return new AccountDto
            {
                AccountId = accountModel.AccountId,
                Email = accountModel.Email,
                Password = accountModel.Password,
                Name = accountModel.Name,
                RoleId = accountModel.RoleId
            };
        }
    }
}