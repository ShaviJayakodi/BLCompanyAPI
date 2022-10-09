using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLCompanyAPI.DataAccess.Migrations
{
    public partial class ordrer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dilevaryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                });

            migrationBuilder.CreateTable(
                name: "FlowerOrder",
                columns: table => new
                {
                    flowersflowerId = table.Column<int>(type: "int", nullable: false),
                    ordersorderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerOrder", x => new { x.flowersflowerId, x.ordersorderId });
                    table.ForeignKey(
                        name: "FK_FlowerOrder_Flowers_flowersflowerId",
                        column: x => x.flowersflowerId,
                        principalTable: "Flowers",
                        principalColumn: "flowerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowerOrder_Orders_ordersorderId",
                        column: x => x.ordersorderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowerOrder_ordersorderId",
                table: "FlowerOrder",
                column: "ordersorderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerOrder");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
