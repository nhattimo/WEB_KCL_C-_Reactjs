using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class NavList
{
    public int NavListId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public int? NavId { get; set; }

    public virtual Navigation? Nav { get; set; }
}
