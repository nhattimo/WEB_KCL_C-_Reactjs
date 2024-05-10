using KCL_Web.Server.Dtos.Navigation;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class NavigationRepository : INavigationRepository
    {
        private readonly KclinicKclWebsiteContext _context;

        public NavigationRepository(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        public async Task<Navigation> CreateAsync(Navigation navigationModel)
        {
            await _context.Navigations.AddAsync(navigationModel);
            await _context.SaveChangesAsync();
            return navigationModel;
        }

        public async Task<Navigation?> DeleteAsync(int id)
        {
            var navigationModel = await _context.Navigations
            .FirstOrDefaultAsync(x => x.NavId == id);

            if (navigationModel == null)
                return null;

            _context.Navigations.Remove(navigationModel);
            await _context.SaveChangesAsync();
            return navigationModel;
        }

        public async Task<List<Navigation>> GetAllAsync()
        {
            return await _context.Navigations.ToListAsync();

        }

        public async Task<Navigation?> GetByIdAsync(int id)
        {
            return await _context.Navigations.FindAsync(id);
        }

        public Task<bool> NavigationExists(int id)
        {
            return _context.Navigations.AnyAsync(s => s.NavId == id);
        }

        public async Task<Navigation?> UpdateAsync(int id, UpdateNavigationRequestDto navigationDto)
        {
            var existingNavigation = await _context.Navigations.FirstOrDefaultAsync(x => x.NavId == id);

            if (existingNavigation == null)
            {
                return null;
            }

            existingNavigation.NavUrl = navigationDto.NavUrl;
            existingNavigation.NavTitle = navigationDto.NavTitle;

            await _context.SaveChangesAsync();
            return existingNavigation;
        }

    }
}