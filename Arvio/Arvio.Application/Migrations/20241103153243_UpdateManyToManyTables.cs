using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arvio.Application.Migrations
{
    /// <inheritdoc />
    public partial class UpdateManyToManyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Orders_OrdersOrderId",
                table: "Orders_Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Products_ProductsProductId",
                table: "Orders_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "Orders_Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "OrdersOrderId",
                table: "Orders_Products",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Products_ProductsProductId",
                table: "Orders_Products",
                newName: "IX_Orders_Products_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_User_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Orders",
                table: "Orders_Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Products",
                table: "Orders_Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_User_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Orders",
                table: "Orders_Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Products",
                table: "Orders_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Orders_Products",
                newName: "ProductsProductId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders_Products",
                newName: "OrdersOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Products_ProductId",
                table: "Orders_Products",
                newName: "IX_Orders_Products_ProductsProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Orders_OrdersOrderId",
                table: "Orders_Products",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Products_ProductsProductId",
                table: "Orders_Products",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
