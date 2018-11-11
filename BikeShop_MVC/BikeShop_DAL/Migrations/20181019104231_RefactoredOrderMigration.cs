using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShop_DAL.Migrations
{
    public partial class RefactoredOrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfExecute",
                table: "Orders",
                newName: "OrderDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "DateOfExecute");
        }
    }
}
