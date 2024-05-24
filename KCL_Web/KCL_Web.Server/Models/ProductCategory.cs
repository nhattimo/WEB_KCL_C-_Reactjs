using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class ProductCategory
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với AppUser
    public string? AppUserId { get; set; }
    public virtual AppUser? AppUser { get; set; }

    // Danh sách các sản phẩm trong danh mục sản phẩm
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
