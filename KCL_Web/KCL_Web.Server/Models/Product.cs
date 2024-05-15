using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public byte? Status { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với ProductCatogory
    public int? CatogoryId { get; set; }
    public virtual ProductCatogory? Catogory { get; set; }

    // Khóa ngoại cho mối quan hệ một-nhiều với Portfolio
    public int? PortfolioId { get; set; }
    public virtual Portfolio? Portfolio { get; set; }
}
