namespace KCL_Web.Server.Dtos.Banner
{
    public class UpdateBannerRequestDto
    {
        public string? BannerName { get; set; }
        public IFormFile? Image { get; set; }
        public string? ImageData { get; set; }
    }
}