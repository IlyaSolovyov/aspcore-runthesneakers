using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RunTheSneakers.Models;

namespace RunTheSneakers.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170817125240_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Apartment");

                    b.Property<int>("Building");

                    b.Property<string>("City");

                    b.Property<string>("Street");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("RunTheSneakers.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandLogoUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Deal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("End");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Start");

                    b.HasKey("Id");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("RunTheSneakers.Models.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DealId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Percentage");

                    b.HasKey("Id");

                    b.HasIndex("DealId");

                    b.ToTable("Discount");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Discount");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeliveryMethodId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RunTheSneakers.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalDescription");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("GenderId");

                    b.Property<int>("MaterialId");

                    b.Property<int>("ModelId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ModelId");

                    b.ToTable("Product");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("RunTheSneakers.Models.ProductColor", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("ColorId");

                    b.HasKey("ProductId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("RunTheSneakers.Models.ProductPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PhotoType");

                    b.Property<int>("ProductId");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductPhotos");
                });

            modelBuilder.Entity("RunTheSneakers.Models.ProductSize", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("SizeId");

                    b.Property<int>("Quantity");

                    b.HasKey("ProductId", "SizeId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Size");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Size");
                });

            modelBuilder.Entity("RunTheSneakers.Models.DiscountByBrand", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Discount");

                    b.Property<int>("BrandId");

                    b.HasIndex("BrandId");

                    b.ToTable("DiscountByBrand");

                    b.HasDiscriminator().HasValue("DiscountByBrand");
                });

            modelBuilder.Entity("RunTheSneakers.Models.DiscountByProduct", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Discount");

                    b.Property<int>("ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("DiscountByProduct");

                    b.HasDiscriminator().HasValue("DiscountByProduct");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Apparel", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Product");


                    b.ToTable("Apparel");

                    b.HasDiscriminator().HasValue("Apparel");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Backpack", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Product");


                    b.ToTable("Backpack");

                    b.HasDiscriminator().HasValue("Backpack");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Headwear", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Product");


                    b.ToTable("Headwear");

                    b.HasDiscriminator().HasValue("Headwear");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Sneaker", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Product");


                    b.ToTable("Sneaker");

                    b.HasDiscriminator().HasValue("Sneaker");
                });

            modelBuilder.Entity("RunTheSneakers.Models.SizeApparel", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Size");

                    b.Property<string>("ApparelSize");

                    b.ToTable("SizeApparel");

                    b.HasDiscriminator().HasValue("SizeApparel");
                });

            modelBuilder.Entity("RunTheSneakers.Models.SizeBackpack", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Size");

                    b.Property<string>("BackpackSize");

                    b.ToTable("SizeBackpack");

                    b.HasDiscriminator().HasValue("SizeBackpack");
                });

            modelBuilder.Entity("RunTheSneakers.Models.SizeShoe", b =>
                {
                    b.HasBaseType("RunTheSneakers.Models.Size");

                    b.Property<string>("ShoeSize");

                    b.ToTable("SizeShoe");

                    b.HasDiscriminator().HasValue("SizeShoe");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RunTheSneakers.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RunTheSneakers.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.Address", b =>
                {
                    b.HasOne("RunTheSneakers.Models.ApplicationUser", "User")
                        .WithOne("Address")
                        .HasForeignKey("RunTheSneakers.Models.Address", "UserId");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Discount", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Deal", "Deal")
                        .WithMany("Discounts")
                        .HasForeignKey("DealId");
                });

            modelBuilder.Entity("RunTheSneakers.Models.Model", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.Order", b =>
                {
                    b.HasOne("RunTheSneakers.Models.DeliveryMethod", "DeliveryMethod")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryMethodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RunTheSneakers.Models.OrderItem", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.Product", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Gender", "Gender")
                        .WithMany("Products")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.Material", "Material")
                        .WithMany("Products")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.Model", "Model")
                        .WithMany("Products")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.ProductColor", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Color", "Color")
                        .WithMany("ProductColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.Product", "Product")
                        .WithMany("Colors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.ProductPhoto", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.ProductSize", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Product", "Product")
                        .WithMany("Sizes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunTheSneakers.Models.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RunTheSneakers.Models.DiscountByBrand", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Brand", "Brand")
                        .WithMany("Discounts")
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("RunTheSneakers.Models.DiscountByProduct", b =>
                {
                    b.HasOne("RunTheSneakers.Models.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("ProductId");
                });
        }
    }
}
