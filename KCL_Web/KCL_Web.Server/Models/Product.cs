using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KCL_Web.Server.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }
    public int? CatogoryId { get; set; }

    public string? UrlImage { get; set; }

    public string? Description { get; set; }


    public byte? Status { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với ProductCategory
    public int? CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public virtual ProductCategory? Category { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với AppUser
    public string? AppUserId { get; set; }
    [ForeignKey("AppUserId")]
    public virtual AppUser? AppUser { get; set; }
}
