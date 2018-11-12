using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShop_DAL.Migrations
{
    public partial class ExtendedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Manufacturer", "Name", "Picture", "Price", "Quantity", "Recommended" },
                values: new object[,]
                {
                    { 21, 1, "The chassis and internals have been specifically engineered for 100 millimeters of travel. No compromises.", "RockShox", "SID World Cup Solo Air Forks-Boost 2017", "product_21.jpg", 374.99m, 150, false },
                    { 47, 2, "Whether going after rail trails, bike paths, suburban streets or light trail rides, the Aggressor Expert will handle any type of ride you throw at it.", "GT", "Aggressor Expert Bike 2019", "product_47.jpg", 499.99m, 80, false },
                    { 48, 2, "Designed with control and balance in mind, your first ride definitely won't be your last.", "GT", "Palomar Al 27.5 Hardtail Mountain Bike 2018", "product_48.jpg", 489.99m, 90, false },
                    { 49, 2, "Building confidence and control as you make your first foray in to off road riding, the Aggressor Sport will see you right, whether you go softly-softly or all guns blazing. ", "GT", "Aggressor Sport Bike 2019", "product_49.jpg", 501.99m, 90, false },
                    { 50, 2, "Referred to as the 'little brother' of the Zaskar by many GT aficionados, the Avalanche Elite 29 Hardtail Mountain Bike gives top-notch performance on every ride", "GT", "Avalanche Elite 29 Hardtail MTB 2018", "product_50.jpg", 529.99m, 90, false },
                    { 51, 4, "Wick sweat fast and carry the comfort of your favourite t-shirt thanks to the Indicator LS Mash Camo Jersey from Fox Racing.", "Fox", "Indicator LS Mash Camo Jersey AW18", "product_51.jpg", 44.99m, 150, false },
                    { 52, 4, "Lightweight and breathable, the Fox Demo LS Camo Burn Jersey is ideal for mountain biking when the weather is warm.", "Fox", "Demo LS Camo Burn Jersey AW18", "product_52.jpg", 45.99m, 150, false },
                    { 53, 4, "The Fox Racing Attack Pro Jersey raises the game when it comes to keeping you cool in hot weather.", "Fox", "Attack Pro Jersey AW18", "product_53.jpg", 46.99m, 150, false },
                    { 54, 4, "A premium-quality MTB jersey without the premium-quality price tag, the Ranger SS Bars Jersey from Fox Racing is here to keep you cool when your ride heats up.", "Fox", "Ranger SS Bars Jersey AW18", "product_54.jpg", 42.99m, 150, false },
                    { 55, 4, "Fox Racing's Demo Long Sleeve MTB Jersey has been raced to success at many World Cup events and offers you lightweight and breathable performance.", "Fox", "Demo Long Sleeve MTB Jersey SS17", "product_55.jpg", 47.99m, 150, false },
                    { 46, 2, "Whether going after rail trails, bike paths, suburban streets or light trail rides, the Aggressor Expert will handle any type of ride you throw at it.", "GT", "Aggressor Expert Bike 2019", "product_46.jpg", 499.99m, 80, false },
                    { 56, 4, "Fox Racing's Indicator MTB Jersey is made of TruDri polyester knit fabric to keep you dry and comfortable.", "Fox", "Indicator Long Sleeve MTB Jersey", "product_56.jpg", 45.99m, 150, false },
                    { 58, 4, "That same great Fox Racing feel, now with added protection from the elements—the perfect choice for unpredictable summer or spring shreds. ", "Fox", "Ranger WR Shorts AW18", "product_58.jpg", 57.99m, 150, false },
                    { 59, 4, "The Downpour Shorts are built using the same durable 3 layer Trumotion 4-way stretch fabric as the Downpour Jacket.", "Fox", "Downpour Shorts SS17", "product_59.jpg", 60.99m, 150, false },
                    { 60, 4, "Made for when the heavens REALLY open, the Downpour Shorts feature Fox Racing’s premier TRUSEAL waterproof membrane within its fabric.", "Fox", "Downpour Shorts 2016", "product_60.jpg", 59.99m, 150, false },
                    { 61, 4, "Despite their camo design, the Fox Racing Ranger Camo Cargo Shorts aren’t hiding their practical and performance advantages in any way.", "Fox", "Ranger Camo Cargo Shorts AW18", "product_61.jpg", 61.99m, 150, false },
                    { 62, 4, "Deeper coverage for those afternoons spent shredding the trail.", "Fox", "Metah Thresh Helmet", "product_62.jpg", 95.99m, 150, false },
                    { 63, 4, "Breathing new life into what is widely recognised as one of Fox Racing’s greatest ever lids, the Flux Helmet is ready and waiting to modernise offroad protection to inspire confidence on the trail.", "Fox", "Flux Helmet AW18", "product_63.jpg", 99.99m, 150, false },
                    { 64, 4, "The Women's Flux Helmet is one of Fox Racing's best-selling AM helmets and provides you with excellent protection thanks to its deep EPS profile.", "Fox", "Womens Flux Helmet", "product_64.jpg", 97.99m, 150, false },
                    { 65, 4, "It’s time to stand up and take notice, cycling’s messiah has been born!", "Fox", "Metah Flow Helmet AW18", "product_65.jpg", 98.99m, 150, false },
                    { 66, 4, "One of Fox Racing’s most popular lids, the Flux Creo Helmet partners you with a real off-road warrior to infuse your ride with high-end coverage and protection.", "Fox", "Flux Creo Helmet", "product_66.jpg", 92.99m, 150, false },
                    { 57, 4, "For downhill riders who love the feel of riding and racing in shorts the Fox Racing Demo Shorts are fantastically durable.", "Fox", "Demo Shorts AW18", "product_57.jpg", 59.99m, 150, false },
                    { 45, 2, "One of GT's most long-serving models for a myriad of reasons, the Avalanche range goes from strength to strength with the upgrades and high-tech build of the Avalanche Comp 29 Hardtail Mountain Bike", "GT", "Avalanche Comp 29 Hardtail Mountain Bike 2018", "product_45.jpg", 539.99m, 80, false },
                    { 44, 2, "A long-running model from hardtail specialists GT, the Avalanche is still a much sought-after mountain bike. ", "GT", "Avalanche Sport 29 Hardtail MTB 2018", "product_44.jpg", 499.99m, 80, false },
                    { 43, 2, "The NS Bikes Snabb 130 Plus 2 Suspension Bike is a great all-round use  trail bike. ", "NS Bikes", "NS Bikes Snabb 130 Plus 2 Suspension Bike 2018", "product_43.jpg", 2229.99m, 80, false },
                    { 22, 1, "The RockShox Revelation has evolved to tackle the most challenging trail and enduro rides.", "RockShox", "Revelation RC DebonAir Forks - Boost 2018", "product_22.jpg", 449.99m, 150, false },
                    { 23, 1, "The RockShox Sektor is a perfect example of trickle down technology. Take the great performance and the chassis of the Revelation and tag it with a price you won't believe.", "RockShox", "Sektor Gold RL Dual Position Coil Forks 2018", "product_23.jpg", 404.99m, 150, false },
                    { 24, 1, "Fox Suspension’s 32 Float Performance Forks are designed to give the most aggressive cross-country racers the smooth performance, low weight and range of adjustments they need to dominate on the most challenging trails.", "Fox", "Fox Suspension 32 Float Performance Forks - QR15 2016", "product_24.jpg", 312.99m, 200, false },
                    { 25, 1, "Fox Suspension’s 32 Float Performance Forks are designed to give the most aggressive cross-country racers the smooth performance, low weight and range of adjustments they need to dominate on the most challenging trails.", "Fox", "Fox Suspension 32 Float Performance Forks - Boost 2017", "product_25.jpg", 374.99m, 200, false },
                    { 26, 1, "The Schwalbe Magic Mary Addix MTB Tyre is the perfect choice for any Track or Trail situation.", "Schwalbe", "Magic Mary Addix MTB Tyre - SnakeSkin", "product_26.jpg", 56.49m, 200, false },
                    { 27, 1, "The Schwalbe Nobby Nic Addix MTB Tyre is a true all rounder that performs brilliantly with any terrain, whatever the weather. Suited perfectly to All-Mountain, Touring, challenging Cross-Country and technical Enduro Trails.", "Schwalbe", "Nobby Nic Addix MTB Tyre - Snakeskin", "product_27.jpg", 53.49m, 200, false },
                    { 28, 1, "Lighter, grippier, faster. The turbo of spike tyres, with 361 spikes it bites firmly into icy roads, the tungsten carbide core of each spike is clad in weight-saving aluminium.", "Schwalbe", "Ice Spiker Pro Winter Tyre - RaceGuard", "product_28.jpg", 49.49m, 200, false },
                    { 29, 1, "The Schwalbe Racing Ralph Addix MTB Tyre is the perfect balance of speed and grip. ", "Schwalbe", "Racing Ralph Addix MTB Tyre - SnakeSkin", "product_29.jpg", 53.49m, 200, false },
                    { 30, 1, "The Schwalbe Black Jack MTB Tyre has a versatile profile with good grip and easy rolling characteristics.", "Schwalbe", "Black Jack MTB Tyre", "product_30.jpg", 17.49m, 200, false },
                    { 31, 1, "The Antares R1 is ideal for cyclists with medium spine flexibility. ", "Fizik", "Antares R1 Carbon Saddle", "product_31.jpg", 84.49m, 200, false },
                    { 32, 1, "Totally new from Fizik. The same great Aliante saddle now with a relief area for better blood flow. ", "Fizik", "Aliante Vs K:IUM Saddle", "product_32.jpg", 79.49m, 200, false },
                    { 33, 1, "With its waved profile that helps you to maintain position when you're pedalling hard and a central cut-out to remove pressure from your sensitive areas.", "Fizik", "Aliante R3 Open Saddle 2018", "product_33.jpg", 77.49m, 200, false },
                    { 34, 1, "Shimano's Saint M820 Disc Brake embraces their Ice Technology, which works to reduce heat and improve braking performance.", "Shimano", "Saint M820 Disc Brake", "product_34.jpg", 177.49m, 200, false },
                    { 35, 1, "The Deore M6000 Disc Brake offers great value for money and gives you plenty of power and control at your fingertips. ", "Shimano", "Deore M6000 Disc Brake", "product_35.jpg", 69.49m, 200, false },
                    { 36, 1, "105 R7020 Hydraulic Disc Brake.", "Shimano", "105 R7020 Hydraulic Disc Brake", "product_36.jpg", 179.49m, 200, false },
                    { 37, 1, "The Shimano XTR M9000 Race Disc Brake is a powerful hydraulic disc brake. ", "Shimano", "XTR M9000 Race Disc Brake", "product_37.jpg", 168.49m, 200, false },
                    { 38, 1, "Shimano HG800 11-Speed Cassette features high end sprockets that provide superior shifting and exceptional drivetrain performance.", "Shimano", "Ultegra HG800 11 Speed Cassette 11-34", "product_38.jpg", 66.49m, 200, false },
                    { 39, 1, "Shimano's SLX M7000 11 Speed 11-42T Cassette utilises their Hyperglide technology alongside a lightweight aluminium spider construction.", "Shimano", "SLX M7000 11 Speed 11-42t Cassette", "product_39.jpg", 62.49m, 200, false },
                    { 40, 1, "This Shimano XT M770 9-Speed MTB Cassette is manufactured to a high-quality and comes with guaranteed durability through the chrome-plated finish, which is resistant to corrosion", "Shimano", "XT M770 9 Speed MTB Cassette", "product_40.jpg", 61.99m, 200, false },
                    { 41, 2, "NS Bikes' Zircus Dirt Jump Bike optimises the same lightweight and strong aluminium frameset.", "NS Bikes", "NS Bikes Zircus Dirt Jump Bike 2018", "product_41.jpg", 609.99m, 200, false },
                    { 42, 2, "The NS Bikes Eccentric Lite 1 features a lightweight but very tough alloy frame. ", "NS Bikes", "NS Bikes Eccentric Lite 1 Hardtail Bike 2018", "product_42.jpg", 809.99m, 200, false },
                    { 67, 2, "The brand new Cross Race C:62 SLT was developed for cyclocross purists like you.", "Cube", "Cross Race C:62 SLT CX Bike 2018", "product_67.jpg", 1988.89m, 50, false },
                    { 68, 1, "The newly redesigned SLX M7000 brings trickle down technology from Shimano's higher tier groups.", "Shimano", "SLX M7000 11 Speed Rear Shifter", "product_68.jpg", 35.89m, 50, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);
        }
    }
}
