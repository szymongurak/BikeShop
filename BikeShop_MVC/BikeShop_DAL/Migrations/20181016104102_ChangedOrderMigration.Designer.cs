﻿// <auto-generated />
using System;
using BikeShop_DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BikeShop_DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181016104102_ChangedOrderMigration")]
    partial class ChangedOrderMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeShop_DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Description = "Parts to your bike", Name = "Bike parts" },
                        new { Id = 2, Description = "Complete bikes which you can buy", Name = "Bikes" },
                        new { Id = 3, Description = "Accessories to your bike", Name = "Bike accessories" },
                        new { Id = 4, Description = "Clothing for all weather conditions", Name = "Bike clothing" }
                    );
                });

            modelBuilder.Entity("BikeShop_DAL.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CostOfShipment");

                    b.Property<DateTime>("DateOfExecute");

                    b.Property<int>("StatusOfOrder");

                    b.Property<decimal>("TotalCost");

                    b.Property<string>("TypeOfShipment");

                    b.Property<string>("UserId");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BikeShop_DAL.Models.OrderPosition", b =>
                {
                    b.Property<int>("OrderPositionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfProduct");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("SelectedQuantity");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("OrderPositionId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderPositions");
                });

            modelBuilder.Entity("BikeShop_DAL.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<bool>("Recommended");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Description = "Hydraulic disc brake. Compatible with mountain bikes.", Manufacturer = "Shimano", Name = "XT M8000 Disc Brake", Picture = "product_1.jpg", Price = 120.0m, Quantity = 100, Recommended = false },
                        new { Id = 2, CategoryId = 1, Description = "10-speed shift lever. Comatibile with shimano drive.", Manufacturer = "Shimano", Name = "Zee M640 Shifter", Picture = "product_2.jpg", Price = 35.0m, Quantity = 250, Recommended = true },
                        new { Id = 3, CategoryId = 1, Description = "Fork for enduro bikes.", Manufacturer = "RockShox", Name = "Pike RCT3 Solo Air Fork", Picture = "product_3.jpg", Price = 520.0m, Quantity = 50, Recommended = false },
                        new { Id = 4, CategoryId = 1, Description = "Carbon frame for enduro bikes.", Manufacturer = "Nukeproof", Name = "Nukeproof Mega 275 Carbon Frame", Picture = "product_4.jpg", Price = 1845.0m, Quantity = 20, Recommended = false },
                        new { Id = 5, CategoryId = 1, Description = "Modern frame for slopestyle bikes.", Manufacturer = "NS Bikes", Name = "NS Bikes Decade Frame 2018", Picture = "product_5.jpg", Price = 240.0m, Quantity = 170, Recommended = true },
                        new { Id = 6, CategoryId = 2, Description = "Modern enduro bike equipped with full suspension frame.", Manufacturer = "NS Bikes", Name = "NS Bikes Snabb 130 Plus 1", Picture = "product_6.jpg", Price = 2335.0m, Quantity = 15, Recommended = false },
                        new { Id = 7, CategoryId = 2, Description = "RoadBike equipped with carbon frame, and disc brakes.", Manufacturer = "Vitus", Name = "Vitesse Evo CRi Disc Bike", Picture = "product_7.jpg", Price = 3099.0m, Quantity = 7, Recommended = false },
                        new { Id = 8, CategoryId = 3, Description = "Delivering stunning performance with on/off road capability, the Volt 800 RC features 5 modes and delivers up to 800 lumens of light.", Manufacturer = "Cateye", Name = "Cateye Volt 800 RC Front Light", Picture = "product_8.jpg", Price = 85.0m, Quantity = 200, Recommended = true },
                        new { Id = 9, CategoryId = 3, Description = "LifeLine's Shock Pump enables you to keep your air suspension at the correct pressure.", Manufacturer = "LifeLine", Name = "LifeLine Shock Pump", Picture = "product_9.jpg", Price = 18.0m, Quantity = 80, Recommended = false },
                        new { Id = 10, CategoryId = 4, Description = "The Brisker Cold Weather Glove from 100% is a minimalist, premium glove that is made from ultra-light materials.", Manufacturer = "100%", Name = "100% Brisker Cold Weather Glove AW17", Picture = "product_10.jpg", Price = 24.5m, Quantity = 75, Recommended = false },
                        new { Id = 11, CategoryId = 4, Description = "This wind/water protection layer is separate from the insulating layer, which ensures excellent ventilation and moisture management.", Manufacturer = "Castelli", Name = "Castelli Alpha Ros Jacket", Picture = "product_11.jpg", Price = 111.3m, Quantity = 25, Recommended = false },
                        new { Id = 12, CategoryId = 1, Description = "Hope's Tech 3 X2 Disc Brake enhances the ergonomics and integration of the system on your cockpit. The Tech 3 master cylinder can operate all calipers across their range and offers an increase of power, of about 5%, over the Tech Evo.", Manufacturer = "Hope Tech", Name = "Hope Tech 3 X2 Blue Disc Brake", Picture = "product_12.jpg", Price = 114.99m, Quantity = 195, Recommended = false },
                        new { Id = 13, CategoryId = 1, Description = "The RockShox Monarch Plus RC3 Rear Shock provides traction-gaining, terrain-conquering suppleness in a lightweight and bombproof package.", Manufacturer = "RockShox", Name = "Monarch Plus RC3 Rear Shock", Picture = "product_13.jpg", Price = 386.49m, Quantity = 12, Recommended = false },
                        new { Id = 14, CategoryId = 1, Description = "The Schwalbe Hans Dampf Addix MTB Tyre has an exceptionally balanced tread profile, effortlessly putting the rider in full control when riding over rough terrain and when blasting down flowing Single Track trails.", Manufacturer = "Schwalbe", Name = "Hans Dampf Addix MTB Tyre - SnakeSkin", Picture = "product_14.jpg", Price = 44.49m, Quantity = 45, Recommended = false },
                        new { Id = 15, CategoryId = 1, Description = "The Recon Silver RL Solo Air Forks from RockShox combine a super stiff body with bombproof steel upper tubes to produce an incredibly durable fork that can handle some serious abuse.", Manufacturer = "RockShox", Name = "Recon Silver RL Solo Air Forks - 9mmQR", Picture = "product_15.jpg", Price = 264.49m, Quantity = 13, Recommended = false },
                        new { Id = 16, CategoryId = 2, Description = "Cube designed its Cross Race Pro CX Bike with offroad cyclocross races in mind, but they also wanted it to be an ultra-versatile and comfortable ride that can be used all year round.", Manufacturer = "Cube", Name = "Cross Race Pro CX Bike 2018", Picture = "product_16.jpg", Price = 1289.99m, Quantity = 5, Recommended = false },
                        new { Id = 17, CategoryId = 1, Description = "The reliable choice, Shimano's 105 brake caliper is compact and lightweight, offering high performance at a reasonable price.", Manufacturer = "Shimano", Name = "Shimano 105 5800 Road Brake Caliper", Picture = "product_17.jpg", Price = 27.99m, Quantity = 290, Recommended = true },
                        new { Id = 18, CategoryId = 1, Description = "Shimano XT 10-speed chain works smoothly with their new Dyna-Sys 10-speed drivetrain. ", Manufacturer = "Shimano", Name = "XT HG95 SIL-TEC 10 Speed Chain", Picture = "product_18.jpg", Price = 19.89m, Quantity = 35, Recommended = false },
                        new { Id = 19, CategoryId = 1, Description = "This Shimano XT M8000 11-Speed 11-42t Cassette is tuned to maintain your rhythm with a consistent cadence. Shave bike weight off without sacrificing durability or reliability.", Manufacturer = "Shimano", Name = "XT M8000 11 Speed 11-42t Cassette", Picture = "product_19.jpg", Price = 72.89m, Quantity = 55, Recommended = false },
                        new { Id = 20, CategoryId = 1, Description = "Choose the chainring you need and tailor your crankset to ride anywhere with this Shimano XT M8000 Single 11-Speed Crankset.", Manufacturer = "Shimano", Name = "XT M8000 Single 11 Speed Crankset", Picture = "product_20.jpg", Price = 111.49m, Quantity = 80, Recommended = false }
                    );
                });

            modelBuilder.Entity("BikeShop_DAL.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BikeShop_DAL.Models.Order", b =>
                {
                    b.HasOne("BikeShop_DAL.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BikeShop_DAL.Models.OrderPosition", b =>
                {
                    b.HasOne("BikeShop_DAL.Models.Order", "Order")
                        .WithMany("OrderPositions")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BikeShop_DAL.Models.Product", "Product")
                        .WithMany("OrderPositions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BikeShop_DAL.Models.Product", b =>
                {
                    b.HasOne("BikeShop_DAL.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BikeShop_DAL.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BikeShop_DAL.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BikeShop_DAL.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BikeShop_DAL.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
