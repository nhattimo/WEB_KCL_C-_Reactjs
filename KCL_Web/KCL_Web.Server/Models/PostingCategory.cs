using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class PostingCategory
{
    [Key]
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public byte? Status { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với Portfolio
    public int? PortfolioId { get; set; }
    public virtual Portfolio? Portfolio { get; set; }

    // Danh sách các bài viết trong danh mục đăng bài
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
