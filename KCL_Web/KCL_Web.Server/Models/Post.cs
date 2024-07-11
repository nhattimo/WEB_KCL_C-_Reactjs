using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KCL_Web.Server.Models;

public partial class Post
{
    [Key]
    public int PostId { get; set; }

    public string? Title { get; set; }

    public string? IntroContent { get; set; } 
    public string? Content { get; set; }

    //public IFormFile? Image { get; set; }
    public string? ImageUrl { get; set; }

    public DateTime? PostDate { get; set; }

    public string? AuthorName { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public byte? Status { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với PostingCategory
    public int? CategoryId { get; set; }
    public virtual PostingCategory? Category { get; set; }

    public string? AppUserId { get; set; }
    [ForeignKey("AppUserId")]
    public virtual AppUser? AppUser { get; set; }
}
