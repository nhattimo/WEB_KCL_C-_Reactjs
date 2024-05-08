using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public byte? Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? RoleId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<PostingCategory> PostingCategories { get; set; } = new List<PostingCategory>();

    public virtual ICollection<ProductCatogory> ProductCatogories { get; set; } = new List<ProductCatogory>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual Role? Role { get; set; }
}
