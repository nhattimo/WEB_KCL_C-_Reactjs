using KCL_Web.Server.Dtos.NavList;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class NavListRepository : INavListRepository
    {
        private readonly KclinicKclWebsiteContext _context;

        public NavListRepository(KclinicKclWebsiteContext context)
        {
            _context = context;

        }

        public async Task<NavList> CreateAsync(NavList NavListModel)
        {
            await _context.NavLists.AddAsync(NavListModel);
            await _context.SaveChangesAsync();

            return NavListModel;
        }

        public async Task<NavList?> DeleteAsync(int id)
        {
            var navListModel = await _context.NavLists.FirstOrDefaultAsync(n => n.NavListId == id);

            if (navListModel == null)
            {
                return null;
            }

            _context.NavLists.Remove(navListModel);
            await _context.SaveChangesAsync();

            return navListModel;
        }

        public async Task<List<NavList>> GetAllAsync()
        {
            return await _context.NavLists.ToListAsync();
        }

        public async Task<NavList?> GetByIdAsync(int id)
        {
            return await _context.NavLists.FindAsync(id);
        }

        public async Task<NavList?> UpdateAsync(int id, NavList NavListModel)
        {
            var existingNavList = await _context.NavLists.FindAsync(id);
            if (existingNavList == null)
            {
                return null;
            }
            existingNavList.Title = NavListModel.Title;
            existingNavList.Url = NavListModel.Url;

            await _context.SaveChangesAsync();

            return existingNavList;
        }
    }
}