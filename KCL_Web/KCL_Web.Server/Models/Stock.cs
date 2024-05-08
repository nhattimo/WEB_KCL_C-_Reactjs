using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Stock
{
    public int Id { get; set; }

    public string Synbol { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public decimal Purchase { get; set; }

    public decimal LastDiv { get; set; }

    public string Industry { get; set; } = null!;

    public string MarketCup { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
