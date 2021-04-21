using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopNuocHoa.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngày lập",
                table: "DonHangs",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 21, 14, 49, 24, 495, DateTimeKind.Local).AddTicks(4337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 21, 10, 57, 22, 768, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "MaBlog", "Ảnh", "Nội dung", "Tiêu Đề" },
                values: new object[,]
                {
                    { 1, "1605854118.02.jpg", "Abc d e f sfkjsa dfjdfk", null },
                    { 2, "1600330492.4583.jpg", "Thắng đẹp trai nhất vũ trụ", null },
                    { 3, "1605854118.02.jpg", "Hôm nay trời đẹp thế nhoỏoo, ỏoooo", "Hí Anh Em" },
                    { 4, "1601518960.3043.jpg", "Hí Anh Em", "Hôm nay tôi off stream :))" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "MaBlog",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "MaBlog",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "MaBlog",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "MaBlog",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngày lập",
                table: "DonHangs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 21, 10, 57, 22, 768, DateTimeKind.Local).AddTicks(3309),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 21, 14, 49, 24, 495, DateTimeKind.Local).AddTicks(4337));
        }
    }
}
