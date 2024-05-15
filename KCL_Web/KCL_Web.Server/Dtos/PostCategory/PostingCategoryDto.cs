namespace KCL_Web.Server.Dtos.PostCategory
{
    public class PostingCategoryDto
    {
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public byte? Status { get; set; }

        public int? AccountId { get; set; }
    }
}
