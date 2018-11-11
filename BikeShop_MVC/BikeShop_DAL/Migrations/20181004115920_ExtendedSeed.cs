using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShop_DAL.Migrations
{
    public partial class ExtendedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 2, "Complete bikes which you can buy", "Bikes" },
                    { 3, "Accessories to your bike", "Bike accessories" },
                    { 4, "Clothing for all weather conditions", "Bike clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Manufacturer", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 4, 1, "Carbon frame for enduro bikes.", "Nukeproof", "Nukeproof Mega 275 Carbon Frame", 1845.0m, 2 },
                    { 5, 1, "Modern frame for slopestyle bikes.", "NS Bikes", "NS Bikes Decade Frame 2018", 240.0m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Manufacturer", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 6, 2, "Modern enduro bike equipped with full suspension frame.", "NS Bikes", "NS Bikes Snabb 130 Plus 1", 2335.0m, 4 },
                    { 7, 2, "RoadBike equipped with carbon frame, and disc brakes.", "Vitus", "Vitesse Evo CRi Disc Bike", 3099.0m, 2 },
                    { 8, 3, "Delivering stunning performance with on/off road capability, the Volt 800 RC features 5 modes and delivers up to 800 lumens of light.", "Cateye", "Cateye Volt 800 RC Front Light", 85.0m, 20 },
                    { 9, 3, "LifeLine's Shock Pump enables you to keep your air suspension at the correct pressure.", "LifeLine", "LifeLine Shock Pump", 18.0m, 15 },
                    { 10, 4, "The Brisker Cold Weather Glove from 100% is a minimalist, premium glove that is made from ultra-light materials.", "100%", "100% Brisker Cold Weather Glove AW17", 24.5m, 7 },
                    { 11, 4, "This wind/water protection layer is separate from the insulating layer, which ensures excellent ventilation and moisture management.", "Castelli", "Castelli Alpha Ros Jacket", 111.3m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
