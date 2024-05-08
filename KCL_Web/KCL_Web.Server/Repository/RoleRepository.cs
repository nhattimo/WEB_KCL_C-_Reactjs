using KCL_Web.Server.Dtos.Role;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly KclinicKclWebsiteContext _context;

        public RoleRepository(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        public async Task<Role> CreateAsync(Role roleModel)
        {
            await _context.Roles.AddAsync(roleModel);
            await _context.SaveChangesAsync();
            return roleModel;
        }

        public async Task<Role?> DeleteAsync(int id)
        {
            var roleModel = await _context.Roles.FirstOrDefaultAsync(r => r.RoleId == id);
            if (roleModel == null)
            {
                return null;
            }
            _context.Roles.Remove(roleModel);
            await _context.SaveChangesAsync();
            return roleModel;
        }

        public async Task<List<Role>> GetAllAsync()
        {
            return await _context.Roles.Include(a => a.Accounts).ToListAsync();
        }

        public async Task<Role?> GetByIdAsync(int id)
        {
            return await _context.Roles.Include(a => a.Accounts).FirstOrDefaultAsync(i => i.RoleId == id);

        }

        public Task<bool> RoleExists(int id)
        {
            return _context.Roles.AnyAsync(r => r.RoleId == id);
        }

        public async Task<Role?> UpdateAsync(int id, UpdateRoleRequestDto roleDto)
        {
            var existingRole = await _context.Roles.FirstOrDefaultAsync(r => r.RoleId == id);

            if (existingRole == null)
                return null;

            existingRole.RoleName = roleDto.RoleName;
            existingRole.RoleDescription = roleDto.RoleDescription;

            await _context.SaveChangesAsync();

            return existingRole;
        }
    }
}