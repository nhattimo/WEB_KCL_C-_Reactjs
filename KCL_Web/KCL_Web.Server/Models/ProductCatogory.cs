using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class ProductCatogory
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với Portfolio
    public int? PortfolioId { get; set; }
    public virtual Portfolio? Portfolio { get; set; }

    // Danh sách các sản phẩm trong danh mục sản phẩm
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
