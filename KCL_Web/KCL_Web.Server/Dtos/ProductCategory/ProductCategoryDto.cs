namespace KCL_Web.Server.Dtos.ProductCategory
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public byte? Status { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public int? AccountId { get; set; }
    }
}
