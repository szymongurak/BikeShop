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
        public DbSet<Recommendation> Recommendations { get; set; }

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
             },
              new Product()
              {
                  Id = 21,
                  Name = "SID World Cup Solo Air Forks-Boost 2017",
                  Manufacturer = "RockShox",
                  Description = "The chassis and internals have been specifically engineered for 100 millimeters of travel. No compromises.",
                  Price = 374.99M,
                  Quantity = 150,
                  Picture = "product_21.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 22,
                  Name = "Revelation RC DebonAir Forks - Boost 2018",
                  Manufacturer = "RockShox",
                  Description = "The RockShox Revelation has evolved to tackle the most challenging trail and enduro rides.",
                  Price = 449.99M,
                  Quantity = 150,
                  Picture = "product_22.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 23,
                  Name = "Sektor Gold RL Dual Position Coil Forks 2018",
                  Manufacturer = "RockShox",
                  Description = "The RockShox Sektor is a perfect example of trickle down technology. Take the great performance and the chassis of the Revelation and tag it with a price you won't believe.",
                  Price = 404.99M,
                  Quantity = 150,
                  Picture = "product_23.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 24,
                  Name = "Fox Suspension 32 Float Performance Forks - QR15 2016",
                  Manufacturer = "Fox",
                  Description = "Fox Suspension’s 32 Float Performance Forks are designed to give the most aggressive cross-country racers the smooth performance, low weight and range of adjustments they need to dominate on the most challenging trails.",
                  Price = 312.99M,
                  Quantity = 200,
                  Picture = "product_24.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 25,
                  Name = "Fox Suspension 32 Float Performance Forks - Boost 2017",
                  Manufacturer = "Fox",
                  Description = "Fox Suspension’s 32 Float Performance Forks are designed to give the most aggressive cross-country racers the smooth performance, low weight and range of adjustments they need to dominate on the most challenging trails.",
                  Price = 374.99M,
                  Quantity = 200,
                  Picture = "product_25.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 26,
                  Name = "Magic Mary Addix MTB Tyre - SnakeSkin",
                  Manufacturer = "Schwalbe",
                  Description = "The Schwalbe Magic Mary Addix MTB Tyre is the perfect choice for any Track or Trail situation.",
                  Price = 56.49M,
                  Quantity = 200,
                  Picture = "product_26.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 27,
                  Name = "Nobby Nic Addix MTB Tyre - Snakeskin",
                  Manufacturer = "Schwalbe",
                  Description = "The Schwalbe Nobby Nic Addix MTB Tyre is a true all rounder that performs brilliantly with any terrain, whatever the weather. Suited perfectly to All-Mountain, Touring, challenging Cross-Country and technical Enduro Trails.",
                  Price = 53.49M,
                  Quantity = 200,
                  Picture = "product_27.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 28,
                  Name = "Ice Spiker Pro Winter Tyre - RaceGuard",
                  Manufacturer = "Schwalbe",
                  Description = "Lighter, grippier, faster. The turbo of spike tyres, with 361 spikes it bites firmly into icy roads, the tungsten carbide core of each spike is clad in weight-saving aluminium.",
                  Price = 49.49M,
                  Quantity = 200,
                  Picture = "product_28.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 29,
                  Name = "Racing Ralph Addix MTB Tyre - SnakeSkin",
                  Manufacturer = "Schwalbe",
                  Description = "The Schwalbe Racing Ralph Addix MTB Tyre is the perfect balance of speed and grip. ",
                  Price = 53.49M,
                  Quantity = 200,
                  Picture = "product_29.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 30,
                  Name = "Black Jack MTB Tyre",
                  Manufacturer = "Schwalbe",
                  Description = "The Schwalbe Black Jack MTB Tyre has a versatile profile with good grip and easy rolling characteristics.",
                  Price = 17.49M,
                  Quantity = 200,
                  Picture = "product_30.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 31,
                  Name = "Antares R1 Carbon Saddle",
                  Manufacturer = "Fizik",
                  Description = "The Antares R1 is ideal for cyclists with medium spine flexibility. ",
                  Price = 84.49M,
                  Quantity = 200,
                  Picture = "product_31.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 32,
                  Name = "Aliante Vs K:IUM Saddle",
                  Manufacturer = "Fizik",
                  Description = "Totally new from Fizik. The same great Aliante saddle now with a relief area for better blood flow. ",
                  Price = 79.49M,
                  Quantity = 200,
                  Picture = "product_32.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 33,
                  Name = "Aliante R3 Open Saddle 2018",
                  Manufacturer = "Fizik",
                  Description = "With its waved profile that helps you to maintain position when you're pedalling hard and a central cut-out to remove pressure from your sensitive areas.",
                  Price = 77.49M,
                  Quantity = 200,
                  Picture = "product_33.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 34,
                  Name = "Saint M820 Disc Brake",
                  Manufacturer = "Shimano",
                  Description = "Shimano's Saint M820 Disc Brake embraces their Ice Technology, which works to reduce heat and improve braking performance.",
                  Price = 177.49M,
                  Quantity = 200,
                  Picture = "product_34.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 35,
                  Name = "Deore M6000 Disc Brake",
                  Manufacturer = "Shimano",
                  Description = "The Deore M6000 Disc Brake offers great value for money and gives you plenty of power and control at your fingertips. ",
                  Price = 69.49M,
                  Quantity = 200,
                  Picture = "product_35.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 36,
                  Name = "105 R7020 Hydraulic Disc Brake",
                  Manufacturer = "Shimano",
                  Description = "105 R7020 Hydraulic Disc Brake.",
                  Price = 179.49M,
                  Quantity = 200,
                  Picture = "product_36.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 37,
                  Name = "XTR M9000 Race Disc Brake",
                  Manufacturer = "Shimano",
                  Description = "The Shimano XTR M9000 Race Disc Brake is a powerful hydraulic disc brake. ",
                  Price = 168.49M,
                  Quantity = 200,
                  Picture = "product_37.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 38,
                  Name = "Ultegra HG800 11 Speed Cassette 11-34",
                  Manufacturer = "Shimano",
                  Description = "Shimano HG800 11-Speed Cassette features high end sprockets that provide superior shifting and exceptional drivetrain performance.",
                  Price = 66.49M,
                  Quantity = 200,
                  Picture = "product_38.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 39,
                  Name = "SLX M7000 11 Speed 11-42t Cassette",
                  Manufacturer = "Shimano",
                  Description = "Shimano's SLX M7000 11 Speed 11-42T Cassette utilises their Hyperglide technology alongside a lightweight aluminium spider construction.",
                  Price = 62.49M,
                  Quantity = 200,
                  Picture = "product_39.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 40,
                  Name = "XT M770 9 Speed MTB Cassette",
                  Manufacturer = "Shimano",
                  Description = "This Shimano XT M770 9-Speed MTB Cassette is manufactured to a high-quality and comes with guaranteed durability through the chrome-plated finish, which is resistant to corrosion",
                  Price = 61.99M,
                  Quantity = 200,
                  Picture = "product_40.jpg",
                  Recommended = false,
                  CategoryId = 1
              },
              new Product()
              {
                  Id = 41,
                  Name = "NS Bikes Zircus Dirt Jump Bike 2018",
                  Manufacturer = "NS Bikes",
                  Description = "NS Bikes' Zircus Dirt Jump Bike optimises the same lightweight and strong aluminium frameset.",
                  Price = 609.99M,
                  Quantity = 200,
                  Picture = "product_41.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 42,
                  Name = "NS Bikes Eccentric Lite 1 Hardtail Bike 2018",
                  Manufacturer = "NS Bikes",
                  Description = "The NS Bikes Eccentric Lite 1 features a lightweight but very tough alloy frame. ",
                  Price = 809.99M,
                  Quantity = 200,
                  Picture = "product_42.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 43,
                  Name = "NS Bikes Snabb 130 Plus 2 Suspension Bike 2018",
                  Manufacturer = "NS Bikes",
                  Description = "The NS Bikes Snabb 130 Plus 2 Suspension Bike is a great all-round use  trail bike. ",
                  Price = 2229.99M,
                  Quantity = 80,
                  Picture = "product_43.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 44,
                  Name = "Avalanche Sport 29 Hardtail MTB 2018",
                  Manufacturer = "GT",
                  Description = "A long-running model from hardtail specialists GT, the Avalanche is still a much sought-after mountain bike. ",
                  Price = 499.99M,
                  Quantity = 80,
                  Picture = "product_44.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 45,
                  Name = "Avalanche Comp 29 Hardtail Mountain Bike 2018",
                  Manufacturer = "GT",
                  Description = "One of GT's most long-serving models for a myriad of reasons, the Avalanche range goes from strength to strength with the upgrades and high-tech build of the Avalanche Comp 29 Hardtail Mountain Bike",
                  Price = 539.99M,
                  Quantity = 80,
                  Picture = "product_45.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 46,
                  Name = "Aggressor Expert Bike 2019",
                  Manufacturer = "GT",
                  Description = "Whether going after rail trails, bike paths, suburban streets or light trail rides, the Aggressor Expert will handle any type of ride you throw at it.",
                  Price = 499.99M,
                  Quantity = 80,
                  Picture = "product_46.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 47,
                  Name = "Aggressor Expert Bike 2019",
                  Manufacturer = "GT",
                  Description = "Whether going after rail trails, bike paths, suburban streets or light trail rides, the Aggressor Expert will handle any type of ride you throw at it.",
                  Price = 499.99M,
                  Quantity = 80,
                  Picture = "product_47.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 48,
                  Name = "Palomar Al 27.5 Hardtail Mountain Bike 2018",
                  Manufacturer = "GT",
                  Description = "Designed with control and balance in mind, your first ride definitely won't be your last.",
                  Price = 489.99M,
                  Quantity = 90,
                  Picture = "product_48.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 49,
                  Name = "Aggressor Sport Bike 2019",
                  Manufacturer = "GT",
                  Description = "Building confidence and control as you make your first foray in to off road riding, the Aggressor Sport will see you right, whether you go softly-softly or all guns blazing. ",
                  Price = 501.99M,
                  Quantity = 90,
                  Picture = "product_49.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 50,
                  Name = "Avalanche Elite 29 Hardtail MTB 2018",
                  Manufacturer = "GT",
                  Description = "Referred to as the 'little brother' of the Zaskar by many GT aficionados, the Avalanche Elite 29 Hardtail Mountain Bike gives top-notch performance on every ride",
                  Price = 529.99M,
                  Quantity = 90,
                  Picture = "product_50.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 51,
                  Name = "Indicator LS Mash Camo Jersey AW18",
                  Manufacturer = "Fox",
                  Description = "Wick sweat fast and carry the comfort of your favourite t-shirt thanks to the Indicator LS Mash Camo Jersey from Fox Racing.",
                  Price = 44.99M,
                  Quantity = 150,
                  Picture = "product_51.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 52,
                  Name = "Demo LS Camo Burn Jersey AW18",
                  Manufacturer = "Fox",
                  Description = "Lightweight and breathable, the Fox Demo LS Camo Burn Jersey is ideal for mountain biking when the weather is warm.",
                  Price = 45.99M,
                  Quantity = 150,
                  Picture = "product_52.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 53,
                  Name = "Attack Pro Jersey AW18",
                  Manufacturer = "Fox",
                  Description = "The Fox Racing Attack Pro Jersey raises the game when it comes to keeping you cool in hot weather.",
                  Price = 46.99M,
                  Quantity = 150,
                  Picture = "product_53.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 54,
                  Name = "Ranger SS Bars Jersey AW18",
                  Manufacturer = "Fox",
                  Description = "A premium-quality MTB jersey without the premium-quality price tag, the Ranger SS Bars Jersey from Fox Racing is here to keep you cool when your ride heats up.",
                  Price = 42.99M,
                  Quantity = 150,
                  Picture = "product_54.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 55,
                  Name = "Demo Long Sleeve MTB Jersey SS17",
                  Manufacturer = "Fox",
                  Description = "Fox Racing's Demo Long Sleeve MTB Jersey has been raced to success at many World Cup events and offers you lightweight and breathable performance.",
                  Price = 47.99M,
                  Quantity = 150,
                  Picture = "product_55.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 56,
                  Name = "Indicator Long Sleeve MTB Jersey",
                  Manufacturer = "Fox",
                  Description = "Fox Racing's Indicator MTB Jersey is made of TruDri polyester knit fabric to keep you dry and comfortable.",
                  Price = 45.99M,
                  Quantity = 150,
                  Picture = "product_56.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 57,
                  Name = "Demo Shorts AW18",
                  Manufacturer = "Fox",
                  Description = "For downhill riders who love the feel of riding and racing in shorts the Fox Racing Demo Shorts are fantastically durable.",
                  Price = 59.99M,
                  Quantity = 150,
                  Picture = "product_57.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 58,
                  Name = "Ranger WR Shorts AW18",
                  Manufacturer = "Fox",
                  Description = "That same great Fox Racing feel, now with added protection from the elements—the perfect choice for unpredictable summer or spring shreds. ",
                  Price = 57.99M,
                  Quantity = 150,
                  Picture = "product_58.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 59,
                  Name = "Downpour Shorts SS17",
                  Manufacturer = "Fox",
                  Description = "The Downpour Shorts are built using the same durable 3 layer Trumotion 4-way stretch fabric as the Downpour Jacket.",
                  Price = 60.99M,
                  Quantity = 150,
                  Picture = "product_59.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 60,
                  Name = "Downpour Shorts 2016",
                  Manufacturer = "Fox",
                  Description = "Made for when the heavens REALLY open, the Downpour Shorts feature Fox Racing’s premier TRUSEAL waterproof membrane within its fabric.",
                  Price = 59.99M,
                  Quantity = 150,
                  Picture = "product_60.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 61,
                  Name = "Ranger Camo Cargo Shorts AW18",
                  Manufacturer = "Fox",
                  Description = "Despite their camo design, the Fox Racing Ranger Camo Cargo Shorts aren’t hiding their practical and performance advantages in any way.",
                  Price = 61.99M,
                  Quantity = 150,
                  Picture = "product_61.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 62,
                  Name = "Metah Thresh Helmet",
                  Manufacturer = "Fox",
                  Description = "Deeper coverage for those afternoons spent shredding the trail.",
                  Price = 95.99M,
                  Quantity = 150,
                  Picture = "product_62.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 63,
                  Name = "Flux Helmet AW18",
                  Manufacturer = "Fox",
                  Description = "Breathing new life into what is widely recognised as one of Fox Racing’s greatest ever lids, the Flux Helmet is ready and waiting to modernise offroad protection to inspire confidence on the trail.",
                  Price = 99.99M,
                  Quantity = 150,
                  Picture = "product_63.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 64,
                  Name = "Womens Flux Helmet",
                  Manufacturer = "Fox",
                  Description = "The Women's Flux Helmet is one of Fox Racing's best-selling AM helmets and provides you with excellent protection thanks to its deep EPS profile.",
                  Price = 97.99M,
                  Quantity = 150,
                  Picture = "product_64.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 65,
                  Name = "Metah Flow Helmet AW18",
                  Manufacturer = "Fox",
                  Description = "It’s time to stand up and take notice, cycling’s messiah has been born!",
                  Price = 98.99M,
                  Quantity = 150,
                  Picture = "product_65.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 66,
                  Name = "Flux Creo Helmet",
                  Manufacturer = "Fox",
                  Description = "One of Fox Racing’s most popular lids, the Flux Creo Helmet partners you with a real off-road warrior to infuse your ride with high-end coverage and protection.",
                  Price = 92.99M,
                  Quantity = 150,
                  Picture = "product_66.jpg",
                  Recommended = false,
                  CategoryId = 4
              },
              new Product()
              {
                  Id = 67,
                  Name = "Cross Race C:62 SLT CX Bike 2018",
                  Manufacturer = "Cube",
                  Description = "The brand new Cross Race C:62 SLT was developed for cyclocross purists like you.",
                  Price = 1988.89M,
                  Quantity = 50,
                  Picture = "product_67.jpg",
                  Recommended = false,
                  CategoryId = 2
              },
              new Product()
              {
                  Id = 68,
                  Name = "SLX M7000 11 Speed Rear Shifter",
                  Manufacturer = "Shimano",
                  Description = "The newly redesigned SLX M7000 brings trickle down technology from Shimano's higher tier groups.",
                  Price = 35.89M,
                  Quantity = 50,
                  Picture = "product_68.jpg",
                  Recommended = false,
                  CategoryId = 1
              }
            );
        }
    }
}
