using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace KCL_Web.Server.Models
{
    public class AppUser : IdentityUser
    {
        public byte? Active { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? Name { get; set; }

        // Danh sách sản phẩm của người dùng
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        public virtual ICollection<PostingCategory> PostingCategories { get; set; } = new List<PostingCategory>();

        public virtual ICollection<ProductCategory> ProductCategorys { get; set; } = new List<ProductCategory>();
    }
}