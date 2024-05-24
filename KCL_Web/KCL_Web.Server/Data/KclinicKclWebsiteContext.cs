using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Models;

public partial class KclinicKclWebsiteContext : IdentityDbContext<AppUser>
{
    public KclinicKclWebsiteContext()
    {
    }

    public KclinicKclWebsiteContext(DbContextOptions<KclinicKclWebsiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<NavList> NavLists { get; set; }

    public virtual DbSet<Navigation> Navigations { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostingCategory> PostingCategories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategorys { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
        builder.Entity<IdentityRole>().HasData(roles);
    }
}
