using KCL_Web.Server.Dtos.Banner;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    public static class BannerMappers
    {
        public static BannerDto ToBannerDto(this Banner bannerModel)
        {
            return new BannerDto
            {
                BannerId = bannerModel.BannerId,
                BannerName = bannerModel.BannerName,
                ImageData = bannerModel.ImageData
            };
        }

        public static Banner ToBannerFromCreateDto(this CreateBannerRequestDto bannerDto)
        {
            return new Banner
            {
                BannerName = bannerDto.BannerName,
                ImageData = bannerDto.ImageData
            };
        }
    }
}