using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class Navigation
{
    [Key]
    public int NavId { get; set; }

    public string? NavTitle { get; set; }

    public string? NavUrl { get; set; }

    // Danh sách các mục điều hướng trong điều hướng
    public virtual ICollection<NavList> NavLists { get; set; } = new List<NavList>();
}
