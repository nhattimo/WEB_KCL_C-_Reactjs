using KCL_Web.Server.Dtos.Role;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllAsync();
        Task<Role?> GetByIdAsync(int id);
        Task<Role> CreateAsync(Role roleModel);
        Task<Role?> UpdateAsync(int id, UpdateRoleRequestDto roleDto);
        Task<Role?> DeleteAsync(int id);
        Task<bool> RoleExists(int id);
    }
}