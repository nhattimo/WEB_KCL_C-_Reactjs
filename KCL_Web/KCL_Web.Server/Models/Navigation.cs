using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Navigation
{
    public int NavId { get; set; }

    public string? NavTitle { get; set; }

    public string? NavUrl { get; set; }

    public virtual ICollection<NavList> NavLists { get; set; } = new List<NavList>();
}
