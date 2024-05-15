using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KCL_Web.Server.Models;

public partial class Role
{
    [Key]
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDescription { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
