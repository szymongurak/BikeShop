using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShop_DAL.Migrations
{
    public partial class ChangedOrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SummaryCost",
                table: "Orders",
                newName: "TotalCost");

            migrationBuilder.AddColumn<string>(
                name: "NameOfProduct",
                table: "OrderPositions",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "OrderPositions",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "OrderPositions",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfProduct",
                table: "OrderPositions");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderPositions");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderPositions");

            migrationBuilder.RenameColumn(
                name: "TotalCost",
                table: "Orders",
                newName: "SummaryCost");
        }
    }
}
