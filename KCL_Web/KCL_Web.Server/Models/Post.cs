using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Post
{
    public int PostId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime? PostDate { get; set; }

    public string? AuthorName { get; set; }

    public int? CategoryId { get; set; }

    public virtual PostingCategory? Category { get; set; }
}
