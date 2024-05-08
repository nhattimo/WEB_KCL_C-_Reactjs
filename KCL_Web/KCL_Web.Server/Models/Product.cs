using System;
using System.Collections.Generic;

namespace KCL_Web.Server.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public byte? Status { get; set; }

    public int? CatogoryId { get; set; }

    public string? UrlImage { get; set; }

    public string? Description { get; set; }

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ProductCatogory? Catogory { get; set; }
}
