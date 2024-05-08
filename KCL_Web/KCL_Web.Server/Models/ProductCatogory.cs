using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class ProductCatogory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
