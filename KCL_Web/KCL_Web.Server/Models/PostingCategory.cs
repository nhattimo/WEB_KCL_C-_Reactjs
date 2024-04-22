using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class PostingCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
