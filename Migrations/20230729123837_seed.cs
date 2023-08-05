using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace shoppingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "type");

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "fastCharge",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "model",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "waterproof",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "brand", "fastCharge", "model", "price", "rating", "stock", "type", "waterproof" },
                values: new object[,]
                {
                    { 1, "Philips", true, "Series 7000", 150, 5, 10, "Shaver", true },
                    { 2, "Braun", false, "Series 9", 250, 4, 20, "Shaver", true },
                    { 3, "Panasonic", true, "Arc5", 200, 4, 15, "Shaver", true },
                    { 4, "Philips", false, "OneBlade", 50, 4, 30, "Shaver", true },
                    { 5, "Philips", false, "AquaTouch", 80, 3, 20, "Shaver", true },
                    { 6, "Philips", true, "Series 5000", 120, 5, 10, "Shaver", true },
                    { 7, "Braun", true, "Series 7", 180, 4, 25, "Shaver", true },
                    { 8, "Braun", false, "Series 5", 130, 4, 15, "Shaver", true },
                    { 9, "Braun", false, "Series 3 ProSkin", 70, 3, 20, "Shaver", true },
                    { 10, "Panasonic", true, "Arc4", 120, 4, 15, "Shaver", true },
                    { 11, "Panasonic", false, "Arc3", 90, 4, 20, "Shaver", true },
                    { 12, "Panasonic", true, "ES-LV95-S", 200, 5, 10, "Shaver", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "brand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "fastCharge",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "model",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "stock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "waterproof",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Products",
                newName: "name");
        }
    }
}
