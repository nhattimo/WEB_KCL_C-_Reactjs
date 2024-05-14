using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KCL_Web.Server.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        [Key]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public byte? Active { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? Name { get; set; }

        // Mối quan hệ một-một giữa Portfolio và PostingCategory
        [ForeignKey("PostingCategory")]
        public int PostingCategoryId { get; set; }
        public PostingCategory PostingCategories { get; set; }

        // Mối quan hệ một-một giữa Portfolio và ProductCatogory
        [ForeignKey("ProductCatogory")]
        public int ProductCatogoryId { get; set; }
        public ProductCatogory ProductCatogories { get; set; }

        // Mối quan hệ một-nhiều giữa Portfolio và Product
        public List<Product> Products { get; set; } = new List<Product>();
    }
}