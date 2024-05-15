namespace KCL_Web.Server.Dtos.Product
{
    public class UpdatedProduct
    {
        public string? Name { get; set; }

        public DateTime? AddedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public byte? Status { get; set; }

        public int? CatogoryId { get; set; }

        public string? UrlImage { get; set; }

        public string? Description { get; set; }

        public int? AccountId { get; set; }
    }
}
