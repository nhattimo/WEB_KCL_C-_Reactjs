using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Conten { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int? StockId { get; set; }

    public virtual Stock? Stock { get; set; }
}
