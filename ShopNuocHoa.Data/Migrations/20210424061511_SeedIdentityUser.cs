using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopNuocHoa.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngày lập",
                table: "DonHangs",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 24, 13, 15, 10, 895, DateTimeKind.Local).AddTicks(1284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 21, 16, 36, 18, 412, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Mota", "Name", "NormalizedName" },
                values: new object[] { new Guid("d167367d-c54e-4b3d-b56b-2f318e515eba"), "54d73962-5137-4a67-a691-fcdfd5a0308d", "Admin Role", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d167367d-c54e-4b3d-b56b-2f318e515eba"), new Guid("afc1b360-b3d3-47ed-b7fe-13623e3addd2") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("afc1b360-b3d3-47ed-b7fe-13623e3addd2"), 0, "8920e2a3-f5ae-4dfd-88cb-516d23ec6382", new DateTime(1999, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "soivadongbon@gmail.com", true, "Thang", "Do", false, null, "soivadongbon@gmail.com", "admin", "AQAAAAEAACcQAAAAEO11djsYAFyYhNcjCMazM49XgEM41//DLdO9iz4hPy7fXU8PA7or969NB+aJFwWStw==", null, false, "", false, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d167367d-c54e-4b3d-b56b-2f318e515eba"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d167367d-c54e-4b3d-b56b-2f318e515eba"), new Guid("afc1b360-b3d3-47ed-b7fe-13623e3addd2") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afc1b360-b3d3-47ed-b7fe-13623e3addd2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngày lập",
                table: "DonHangs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 21, 16, 36, 18, 412, DateTimeKind.Local).AddTicks(3015),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 24, 13, 15, 10, 895, DateTimeKind.Local).AddTicks(1284));
        }
    }
}
