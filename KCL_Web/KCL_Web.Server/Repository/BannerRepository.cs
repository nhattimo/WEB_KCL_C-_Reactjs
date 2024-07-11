using AutoMapper;
using KCL_Web.Server.Dtos.Banner;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using KCL_Web.Server.Models;
using KCL_Web.Server.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace KCL_Web.Server.Repository
{
    public class BannerRepository : IBannerRepository
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        string[] allowedFileExtentions = [".jpg", ".jpeg", ".png"];
        public BannerRepository(KclinicKclWebsiteContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public Task<bool> BannerExists(int id)
        {
            return _context.Banners.AnyAsync(b => b.BannerId == id);
        }

        public async Task<Banner> CreateAsync(CreateBannerRequestDto bannerDTO)
        {
            if (bannerDTO.Image != null)
            {
                bannerDTO.ImageData = await _fileService.SaveFileAsync(bannerDTO.Image, allowedFileExtentions);
            }
            var banner = bannerDTO.ToBannerFromCreateDto();
            await _context.Banners.AddAsync(banner);
            await _context.SaveChangesAsync();
            return banner;
        }

        public async Task<Banner?> DeleteAsync(int id)
        {
            var existingBanner = await _context.Banners.FirstOrDefaultAsync(b => b.BannerId == id);
            if (existingBanner == null)
            {
                return null;
            }
            if (!string.IsNullOrEmpty(existingBanner.ImageData) && File.Exists(existingBanner.ImageData))
            {

                _fileService.DeleteFile($"{existingBanner.ImageData}");
            }
            _context.Banners.Remove(existingBanner);
            await _context.SaveChangesAsync();

            return existingBanner;
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
        
          
            if (BannerDto.Image != null)
            {
                Console.WriteLine($"BannerDto.Image{BannerDto.Image}" );
                string ImageName = await _fileService.SaveFileAsync(BannerDto.Image, allowedFileExtentions);
                BannerDto.ImageData = ImageName;

                if (!string.IsNullOrEmpty(existingBanner.ImageData) && File.Exists(existingBanner.ImageData))
                {

                    _fileService.DeleteFile($"{existingBanner.ImageData}");
                }
            }

            existingBanner.BannerName = BannerDto.BannerName;
            existingBanner.ImageData = BannerDto.ImageData;

            await _context.SaveChangesAsync();

            return existingBanner;
        }
    }
}