using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class UpdatePro2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://media.gucci.com/style/DarkGray_Center_0_0_2400x2400/1611335703/628572_99999_0099_001_100_0000_Light-Gucci-Bloom-Profumo-di-Fiori-100ml-Eau-de-Parfum.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw71015f31/assets/Y0998004/Y0998004_C099600455_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-m%C3%A9t%C3%A9ore-fragrances--LP0160_PM2_Front%20view.png?wid=1240&hei=1240");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-l-immensit%C3%A9-fragrances--LP0052_PM2_Front%20view.png?wid=1240&hei=1240");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-orage-fragrances--LP0051_PM2_Front%20view.png?wid=1240&hei=1240");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-nouveau-monde-fragrances--LP0053_PM2_Front%20view.png?wid=1240&hei=1240");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1582739103/613748_99999_0099_001_100_0000_Light-Gucci-Guilty-Pour-Homme-90ml-eau-de-parfum.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw59f3c992/assets/Y0996460/Y0996460_C099600755_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-m%C3%A9t%C3%A9ore-fragrances--LP0160_PM1_Interior%20view.png?wid=1080");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-l-immensit%C3%A9-fragrances--LP0052_PM1_Interior%20view.png?wid=1080");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-orage-fragrances--LP0051_PM1_Interior%20view.png?wid=1080");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-nouveau-monde-fragrances--LP0053_PM1_Interior%20view.png?wid=1080");
        }
    }
}
