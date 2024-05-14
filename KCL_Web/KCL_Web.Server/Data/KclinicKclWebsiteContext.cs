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

    public virtual DbSet<ProductCatogory> ProductCatogories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public DbSet<Portfolio> Portfolios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // builder.Entity<Portfolio>(x => x.HasKey(p => new { p.AppUserId, p.StockId }));

        // builder.Entity<Portfolio>()
        //     .HasOne(u => u.AppUser)
        //     .WithMany(u => u.Portfolios)
        //     .HasForeignKey(p => p.AppUserId);

        // builder.Entity<Portfolio>()
        //     .HasOne(u => u.Stock)
        //     .WithMany(u => u.Portfolios)
        //     .HasForeignKey(p => p.StockId);


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
