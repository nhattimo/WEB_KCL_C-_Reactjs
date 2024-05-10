using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface INavListRepository
    {
        Task<List<NavList>> GetAllAsync();
        Task<NavList?> GetByIdAsync(int id);
        Task<NavList> CreateAsync(NavList NavListModel);
        Task<NavList?> UpdateAsync(int id, NavList NavListModel);
        Task<NavList?> DeleteAsync(int id);
    }
}