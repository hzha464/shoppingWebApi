using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoppingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class link : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "image",
                value: "https://www.maquinilladeafeitar.com/wp-content/uploads/2018/01/Philips-serie-7000.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "image",
                value: "https://images-na.ssl-images-amazon.com/images/I/811IO5eKSJL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "image",
                value: "https://moo.review/wp-content/uploads/2016/02/Panasonic-Arc-5-model-ES-LV9N-electric-shaver.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "image",
                value: "https://www.philips.be/c-dam/corporate/newscenter/be/standard/resources/2017/one-blade/philips-one-blade-hi-res-02.download.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "image",
                value: "https://www.bigw.com.au/medias/sys_master/images/images/hb5/h95/10815612026910.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "image",
                value: "https://top-rasage.fr/wp-content/uploads/2018/02/Philips-Series-5000-S531026.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "image",
                value: "https://www.bestshaverszone.com/wp-content/uploads/2015/03/Braun-Series-7-790cc-Pulsonic.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "image",
                value: "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5895/5895021_rd.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "image",
                value: "https://www.mashco.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/bra3000s.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "image",
                value: "https://d11zer3aoz69xt.cloudfront.net/media/catalog/product/cache/1/image/1200x/9df78eab33525d08d6e5fb8d27136e95/p/a/panasonic_arc4_4-blade_shaver_es-lf51-a_11.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "image",
                value: "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6400/6400550_rd.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "image",
                value: "https://c1.neweggimages.com/ProductImageCompressAll1280/96-200-517-02.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Products");
        }
    }
}
