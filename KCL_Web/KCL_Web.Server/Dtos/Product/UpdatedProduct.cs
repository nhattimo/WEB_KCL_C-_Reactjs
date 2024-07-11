namespace KCL_Web.Server.Dtos.Product
{
    public class UpdatedProduct
    {
        public string? Name { get; set; }

        public string? IntroContent { get; set; }
        public DateTime? AddedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public byte? Status { get; set; }

        public int? CategoryId { get; set; }

        public IFormFile? Image { get; set; }
        public string? UrlImage { get; set; }

        public string? Description { get; set; }

        public string? AccountId { get; set; }
    }
}
