using System;
using System.Collections.Generic;
using System.Text;
using BikeShop_DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BikeShop_DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Name = "Bike parts",
                Description = "Parts to your bike"
            },
            new Category()
            {
                Id = 2,
                Name = "Bikes",
                Description = "Complete bikes which you can buy"
            },
            new Category()
            {
                Id = 3,
                Name = "Bike accessories",
                Description = "Accessories to your bike"
            },
            new Category()
            {
                Id = 4,
                Name = "Bike clothing",
                Description = "Clothing for all weather conditions"
            }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                Name = "XT M8000 Disc Brake",
                Manufacturer = "Shimano",
                Description = "Hydraulic disc brake. Compatible with mountain bikes.",
                Price = 120.0M,
                Quantity = 100,
                Picture = "product_1.jpg",
                Recommended = false,
                CategoryId = 1
            },
             new Product()
             {
                 Id = 2,
                 Name = "Zee M640 Shifter",
                 Manufacturer = "Shimano",
                 Description = "10-speed shift lever. Comatibile with shimano drive.",
                 Price = 35.0M,
                 Quantity = 250,
                 Picture = "product_2.jpg",
                 Recommended = true,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 3,
                 Name = "Pike RCT3 Solo Air Fork",
                 Manufacturer = "RockShox",
                 Description = "Fork for enduro bikes.",
                 Price = 520.0M,
                 Quantity = 50,
                 Picture = "product_3.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 4,
                 Name = "Nukeproof Mega 275 Carbon Frame",
                 Manufacturer = "Nukeproof",
                 Description = "Carbon frame for enduro bikes.",
                 Price = 1845.0M,
                 Quantity = 20,
                 Picture = "product_4.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 5,
                 Name = "NS Bikes Decade Frame 2018",
                 Manufacturer = "NS Bikes",
                 Description = "Modern frame for slopestyle bikes.",
                 Price = 240.0M,
                 Quantity = 170,
                 Picture = "product_5.jpg",
                 Recommended = true,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 6,
                 Name = "NS Bikes Snabb 130 Plus 1",
                 Manufacturer = "NS Bikes",
                 Description = "Modern enduro bike equipped with full suspension frame.",
                 Price = 2335.0M,
                 Quantity = 15,
                 Picture = "product_6.jpg",
                 Recommended = false,
                 CategoryId = 2
             },
             new Product()
             {
                 Id = 7,
                 Name = "Vitesse Evo CRi Disc Bike",
                 Manufacturer = "Vitus",
                 Description = "RoadBike equipped with carbon frame, and disc brakes.",
                 Price = 3099.0M,
                 Quantity = 7,
                 Picture = "product_7.jpg",
                 Recommended = false,
                 CategoryId = 2
             },
             new Product()
             {
                 Id = 8,
                 Name = "Cateye Volt 800 RC Front Light",
                 Manufacturer = "Cateye",
                 Description = "Delivering stunning performance with on/off road capability, the Volt 800 RC features 5 modes and delivers up to 800 lumens of light.",
                 Price = 85.0M,
                 Quantity = 200,
                 Picture = "product_8.jpg",
                 Recommended = true,
                 CategoryId = 3
             },
             new Product()
             {
                 Id = 9,
                 Name = "LifeLine Shock Pump",
                 Manufacturer = "LifeLine",
                 Description = "LifeLine's Shock Pump enables you to keep your air suspension at the correct pressure.",
                 Price = 18.0M,
                 Quantity = 80,
                 Picture = "product_9.jpg",
                 Recommended = false,
                 CategoryId = 3
             },
             new Product()
             {
                 Id = 10,
                 Name = "100% Brisker Cold Weather Glove AW17",
                 Manufacturer = "100%",
                 Description = "The Brisker Cold Weather Glove from 100% is a minimalist, premium glove that is made from ultra-light materials.",
                 Price = 24.5M,
                 Quantity = 75,
                 Picture = "product_10.jpg",
                 Recommended = false,
                 CategoryId = 4
             },
             new Product()
             {
                 Id = 11,
                 Name = "Castelli Alpha Ros Jacket",
                 Manufacturer = "Castelli",
                 Description = "This wind/water protection layer is separate from the insulating layer, which ensures excellent ventilation and moisture management.",
                 Price = 111.3M,
                 Quantity = 25,
                 Picture = "product_11.jpg",
                 Recommended = false,
                 CategoryId = 4
             },
             new Product()
             {
                 Id = 12,
                 Name = "Hope Tech 3 X2 Blue Disc Brake",
                 Manufacturer = "Hope Tech",
                 Description = "Hope's Tech 3 X2 Disc Brake enhances the ergonomics and integration of the system on your cockpit. The Tech 3 master cylinder can operate" +
                 " all calipers across their range and offers an increase of power, of about 5%, over the Tech Evo.",
                 Price = 114.99M,
                 Quantity = 195,
                 Picture = "product_12.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 13,
                 Name = "Monarch Plus RC3 Rear Shock",
                 Manufacturer = "RockShox",
                 Description = "The RockShox Monarch Plus RC3 Rear Shock provides traction-gaining, terrain-conquering suppleness in a lightweight and bombproof package.",
                 Price = 386.49M,
                 Quantity = 12,
                 Picture = "product_13.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 14,
                 Name = "Hans Dampf Addix MTB Tyre - SnakeSkin",
                 Manufacturer = "Schwalbe",
                 Description = "The Schwalbe Hans Dampf Addix MTB Tyre has an exceptionally balanced tread profile, effortlessly putting the rider in full control " +
                 "when riding over rough terrain and when blasting down flowing Single Track trails.",
                 Price = 44.49M,
                 Quantity = 45,
                 Picture = "product_14.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 15,
                 Name = "Recon Silver RL Solo Air Forks - 9mmQR",
                 Manufacturer = "RockShox",
                 Description = "The Recon Silver RL Solo Air Forks from RockShox combine a super stiff body with bombproof steel upper tubes to produce an " +
                 "incredibly durable fork that can handle some serious abuse.",
                 Price = 264.49M,
                 Quantity = 13,
                 Picture = "product_15.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 16,
                 Name = "Cross Race Pro CX Bike 2018",
                 Manufacturer = "Cube",
                 Description = "Cube designed its Cross Race Pro CX Bike with offroad cyclocross races in mind, but they also wanted it to be an " +
                 "ultra-versatile and comfortable ride that can be used all year round.",
                 Price = 1289.99M,
                 Quantity = 5,
                 Picture = "product_16.jpg",
                 Recommended = false,
                 CategoryId = 2
             },
             new Product()
             {
                 Id = 17,
                 Name = "Shimano 105 5800 Road Brake Caliper",
                 Manufacturer = "Shimano",
                 Description = "The reliable choice, Shimano's 105 brake caliper is compact and lightweight, offering high performance at a reasonable price.",
                 Price = 27.99M,
                 Quantity = 290,
                 Picture = "product_17.jpg",
                 Recommended = true,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 18,
                 Name = "XT HG95 SIL-TEC 10 Speed Chain",
                 Manufacturer = "Shimano",
                 Description = "Shimano XT 10-speed chain works smoothly with their new Dyna-Sys 10-speed drivetrain. ",
                 Price = 19.89M,
                 Quantity = 35,
                 Picture = "product_18.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 19,
                 Name = "XT M8000 11 Speed 11-42t Cassette",
                 Manufacturer = "Shimano",
                 Description = "This Shimano XT M8000 11-Speed 11-42t Cassette is tuned to maintain your rhythm with a consistent cadence." +
                 " Shave bike weight off without sacrificing durability or reliability.",
                 Price = 72.89M,
                 Quantity = 55,
                 Picture = "product_19.jpg",
                 Recommended = false,
                 CategoryId = 1
             },
             new Product()
             {
                 Id = 20,
                 Name = "XT M8000 Single 11 Speed Crankset",
                 Manufacturer = "Shimano",
                 Description = "Choose the chainring you need and tailor your crankset to ride anywhere with this Shimano XT M8000 Single 11-Speed Crankset.",
                 Price = 111.49M,
                 Quantity = 80,
                 Picture = "product_20.jpg",
                 Recommended = false,
                 CategoryId = 1
             }
            );
        }
    }
}
