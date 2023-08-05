using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoppingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class newproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_order_OrderId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Products_ProductId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProductId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ProductItems",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_OrderId",
                table: "ProductItems",
                newName: "IX_ProductItems_orderId");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_order_orderId",
                table: "ProductItems",
                column: "orderId",
                principalTable: "order",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_order_orderId",
                table: "ProductItems");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "ProductItems",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_orderId",
                table: "ProductItems",
                newName: "IX_ProductItems_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProductId",
                table: "Users",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_order_OrderId",
                table: "ProductItems",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Products_ProductId",
                table: "Users",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
