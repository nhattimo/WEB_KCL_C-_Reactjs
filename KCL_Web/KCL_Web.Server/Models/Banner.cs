using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class Banner
{
    [Key]
    public int BannerId { get; set; }

    public string? BannerName { get; set; }

    public string? ImageData { get; set; }
}
