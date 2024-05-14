using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class NavList
{
    [Key]
    public int NavListId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    // Khóa ngoại cho mối quan hệ nhiều-một với Navigation
    public int? NavId { get; set; }
    public virtual Navigation? Nav { get; set; }
}

