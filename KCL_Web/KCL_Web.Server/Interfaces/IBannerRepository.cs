using KCL_Web.Server.Dtos.Banner;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IBannerRepository
    {
        Task<List<Banner>> GetAllAsync();
        Task<Banner?> GetByIdAsync(int id);
        Task<Banner> CreateAsync(Banner BannerModel);
        Task<Banner?> UpdateAsync(int id, UpdateBannerRequestDto BannerDto);
        Task<Banner?> DeleteAsync(int id);
        Task<bool> BannerExists(int id);
    }
}