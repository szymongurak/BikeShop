using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShop_DAL.Migrations
{
    public partial class AddPictureToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Picture",
                value: "product_1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Picture",
                value: "product_2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Picture",
                value: "product_3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Picture",
                value: "product_4.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Picture",
                value: "product_5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Picture",
                value: "product_6.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Picture",
                value: "product_7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Picture",
                value: "product_8.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Picture",
                value: "product_9.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Picture",
                value: "product_10.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Picture",
                value: "product_11.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Manufacturer", "Name", "Picture", "Price", "Quantity" },
                values: new object[,]
                {
                    { 12, 1, "Hope's Tech 3 X2 Disc Brake enhances the ergonomics and integration of the system on your cockpit. The Tech 3 master cylinder can operate all calipers across their range and offers an increase of power, of about 5%, over the Tech Evo.", "Hope Tech", "Hope Tech 3 X2 Blue Disc Brake", "product_12.jpg", 114.99m, 19 },
                    { 13, 1, "The RockShox Monarch Plus RC3 Rear Shock provides traction-gaining, terrain-conquering suppleness in a lightweight and bombproof package.", "RockShox", "Monarch Plus RC3 Rear Shock", "product_13.jpg", 386.49m, 12 },
                    { 14, 1, "The Schwalbe Hans Dampf Addix MTB Tyre has an exceptionally balanced tread profile, effortlessly putting the rider in full control when riding over rough terrain and when blasting down flowing Single Track trails.", "Schwalbe", "Hans Dampf Addix MTB Tyre - SnakeSkin", "product_14.jpg", 44.49m, 45 },
                    { 15, 1, "The Recon Silver RL Solo Air Forks from RockShox combine a super stiff body with bombproof steel upper tubes to produce an incredibly durable fork that can handle some serious abuse.", "RockShox", "Recon Silver RL Solo Air Forks - 9mmQR", "product_15.jpg", 264.49m, 13 },
                    { 16, 2, "Cube designed its Cross Race Pro CX Bike with offroad cyclocross races in mind, but they also wanted it to be an ultra-versatile and comfortable ride that can be used all year round.", "Cube", "Cross Race Pro CX Bike 2018", "product_16.jpg", 1289.99m, 5 },
                    { 17, 1, "The reliable choice, Shimano's 105 brake caliper is compact and lightweight, offering high performance at a reasonable price.", "Shimano", "Shimano 105 5800 Road Brake Caliper", "product_17.jpg", 27.99m, 9 },
                    { 18, 1, "Shimano XT 10-speed chain works smoothly with their new Dyna-Sys 10-speed drivetrain. ", "Shimano", "XT HG95 SIL-TEC 10 Speed Chain", "product_18.jpg", 19.89m, 12 },
                    { 19, 1, "This Shimano XT M8000 11-Speed 11-42t Cassette is tuned to maintain your rhythm with a consistent cadence. Shave bike weight off without sacrificing durability or reliability.", "Shimano", "XT M8000 11 Speed 11-42t Cassette", "product_19.jpg", 72.89m, 19 },
                    { 20, 1, "Choose the chainring you need and tailor your crankset to ride anywhere with this Shimano XT M8000 Single 11-Speed Crankset.", "Shimano", "XT M8000 Single 11 Speed Crankset", "product_20.jpg", 111.49m, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Products");
        }
    }
}
