 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLCompanyAPI.DataAccess.Migrations
{
    public partial class rela1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stocks_flowerId",
                table: "Stocks");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_flowerId",
                table: "Stocks",
                column: "flowerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stocks_flowerId",
                table: "Stocks");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_flowerId",
                table: "Stocks",
                column: "flowerId");
        }
    }
}
