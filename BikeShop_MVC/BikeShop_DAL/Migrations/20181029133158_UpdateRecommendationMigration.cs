using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShop_DAL.Migrations
{
    public partial class UpdateRecommendationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Products_ProductId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_AspNetUsers_UserId",
                table: "Recommendation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recommendation",
                table: "Recommendation");

            migrationBuilder.RenameTable(
                name: "Recommendation",
                newName: "Recommendations");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendation_UserId",
                table: "Recommendations",
                newName: "IX_Recommendations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendation_ProductId",
                table: "Recommendations",
                newName: "IX_Recommendations_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recommendations",
                table: "Recommendations",
                column: "RecommendationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Products_ProductId",
                table: "Recommendations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId",
                table: "Recommendations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Products_ProductId",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId",
                table: "Recommendations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recommendations",
                table: "Recommendations");

            migrationBuilder.RenameTable(
                name: "Recommendations",
                newName: "Recommendation");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendations_UserId",
                table: "Recommendation",
                newName: "IX_Recommendation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendations_ProductId",
                table: "Recommendation",
                newName: "IX_Recommendation_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recommendation",
                table: "Recommendation",
                column: "RecommendationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Products_ProductId",
                table: "Recommendation",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_AspNetUsers_UserId",
                table: "Recommendation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
