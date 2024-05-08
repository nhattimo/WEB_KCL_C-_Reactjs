using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Banner
{
    public int BannerId { get; set; }

    public string? BannerName { get; set; }

    public string? ImageData { get; set; }
}
