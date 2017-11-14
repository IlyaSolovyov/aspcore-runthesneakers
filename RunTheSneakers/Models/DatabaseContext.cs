using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RunTheSneakers.Models;

namespace RunTheSneakers.Models
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Apparel> Apparel { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<DiscountByBrand> BrandDiscounts { get; set; }
        public DbSet<DiscountByProduct> ProductdDiscounts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Headwear> Headwear { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<SizeApparel> ApparelSizes { get; set; }
        public DbSet<SizeBackpack> BackpackSizes { get; set; }
        public DbSet<SizeShoe> ShoeSizes { get; set; }
        public DbSet<Sneaker> Sneakers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
            .Entity<ApplicationUser>()
            .HasOne(u => u.Address)
            .WithOne(a => a.User)
            .HasForeignKey<Address>(a => a.UserId);

            modelBuilder.Entity<DiscountByProduct>()
                .HasOne(d => d.Product)
                .WithMany(p => p.Discounts)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DiscountByBrand>()
              .HasOne(d=> d.Brand)
              .WithMany(b => b.Discounts)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductSize>()
                .HasKey(t => new { t.ProductId, t.SizeId });

            modelBuilder.Entity<ProductSize>()
          .HasOne(pt => pt.Product)
          .WithMany(p => p.Sizes)
          .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductSize>()
                .HasOne(pt => pt.Size)
                .WithMany(t => t.ProductSizes)
                .HasForeignKey(pt => pt.SizeId);


            modelBuilder.Entity<ProductColor>()
              .HasKey(t => new { t.ProductId, t.ColorId });

            modelBuilder.Entity<ProductColor>()
          .HasOne(pt => pt.Product)
          .WithMany(p => p.Colors)
          .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductColor>()
                .HasOne(pt => pt.Color)
                .WithMany(t => t.ProductColors)
                .HasForeignKey(pt => pt.ColorId);
        }

        public DbSet<RunTheSneakers.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<RunTheSneakers.Models.Product> Product { get; set; }

    }

}
