using KCL_Web.Server.Dtos.Role;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    public static class RoleMappers
    {
        public static RoleDto ToRoleDto(this Role roleModel)
        {
            return new RoleDto
            {
                RoleId = roleModel.RoleId,
                RoleName = roleModel.RoleName,
                RoleDescription = roleModel.RoleDescription,
                //Accounts = roleModel.Accounts.Select(r => r.ToAccountDto()).ToList()
            };
        }

        public static Role ToRoleFromCreateDto(this CreateRoleRequestDto roleDto)
        {
            return new Role
            {
                RoleName = roleDto.RoleName,
                RoleDescription = roleDto.RoleDescription
            };
        }
    }
}