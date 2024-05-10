using KCL_Web.Server.Dtos.Banner;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class BannerRepository : IBannerRepository
    {
        private readonly KclinicKclWebsiteContext _context;

        public BannerRepository(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        public Task<bool> BannerExists(int id)
        {
            return _context.Banners.AnyAsync(b => b.BannerId == id);
        }

        public async Task<Banner> CreateAsync(Banner BannerModel)
        {
            await _context.Banners.AddAsync(BannerModel);
            await _context.SaveChangesAsync();
            return BannerModel;
        }

        public async Task<Banner?> DeleteAsync(int id)
        {
            var bannerModel = await _context.Banners.FirstOrDefaultAsync(b => b.BannerId == id);
            if (bannerModel == null)
            {
                return null;
            }

            _context.Banners.Remove(bannerModel);
            await _context.SaveChangesAsync();

            return bannerModel;
        }

        public async Task<List<Banner>> GetAllAsync()
        {
            return await _context.Banners.ToListAsync();
        }

        public async Task<Banner?> GetByIdAsync(int id)
        {
            return await _context.Banners.FindAsync(id);
        }

        public async Task<Banner?> UpdateAsync(int id, UpdateBannerRequestDto BannerDto)
        {
            var existingBanner = await _context.Banners.FindAsync(id);
            if (existingBanner == null)
            {
                return null;
            }

            existingBanner.BannerName = BannerDto.BannerName;
            existingBanner.ImageData = BannerDto.ImageData;

            await _context.SaveChangesAsync();

            return existingBanner;
        }
    }
}