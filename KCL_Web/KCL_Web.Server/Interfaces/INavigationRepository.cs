using KCL_Web.Server.Dtos.Navigation;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface INavigationRepository
    {
        Task<List<Navigation>> GetAllAsync();
        Task<Navigation?> GetByIdAsync(int id);
        Task<Navigation> CreateAsync(Navigation navigationModel);
        Task<Navigation?> UpdateAsync(int id, UpdateNavigationRequestDto navigationDto);
        Task<Navigation?> DeleteAsync(int id);
    }
}