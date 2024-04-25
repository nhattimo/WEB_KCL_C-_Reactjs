using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Models;

public partial class KclinicKclWebsiteContext : DbContext
{
    public KclinicKclWebsiteContext()
    {
    }

    public KclinicKclWebsiteContext(DbContextOptions<KclinicKclWebsiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<NavList> NavLists { get; set; }

    public virtual DbSet<Navigation> Navigations { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostingCategory> PostingCategories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Accounts__349DA5A6A9B56664");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(255);

            entity.HasOne(d => d.Role).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_Accouts_Roles");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("comment");

            entity.HasIndex(e => e.StockId, "IX_comment_StockId");

            entity.HasOne(d => d.Stock).WithMany(p => p.Comments).HasForeignKey(d => d.StockId);
        });

        modelBuilder.Entity<NavList>(entity =>
        {
            entity.HasKey(e => e.NavListId).HasName("PK__NavLists__2C87D608CDB7A520");

            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.Nav).WithMany(p => p.NavLists)
                .HasForeignKey(d => d.NavId)
                .HasConstraintName("FK_NavList_Navigations");
        });

        modelBuilder.Entity<Navigation>(entity =>
        {
            entity.HasKey(e => e.NavId).HasName("PK__Navigati__67283A53F4359221");

            entity.Property(e => e.NavTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__Posts__AA1260180AF1ED22");

            entity.Property(e => e.AuthorName).HasMaxLength(255);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ImageURL");
            entity.Property(e => e.PostDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.Posts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Posts_Categories");
        });

        modelBuilder.Entity<PostingCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__PostingC__19093A0BA898696E");

            entity.Property(e => e.CategoryName).HasMaxLength(255);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1A44525138");

            entity.Property(e => e.RoleDescription).HasMaxLength(255);
            entity.Property(e => e.RoleName).HasMaxLength(255);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.ToTable("stock");

            entity.Property(e => e.LastDiv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Purchase).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
