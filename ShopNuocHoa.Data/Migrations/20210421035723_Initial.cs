using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopNuocHoa.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    MaBlog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ảnh = table.Column<string>(maxLength: 100, nullable: false),
                    Nộidung = table.Column<string>(name: "Nội dung", maxLength: 3000, nullable: false),
                    TiêuĐề = table.Column<string>(name: "Tiêu Đề", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.MaBlog);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Message = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucs",
                columns: table => new
                {
                    MaDm = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TênDanhMuc = table.Column<string>(name: "Tên DanhMuc", maxLength: 100, nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucs", x => x.MaDm);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    MaDh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngàylập = table.Column<DateTime>(name: "Ngày lập", nullable: true, defaultValue: new DateTime(2021, 4, 21, 10, 57, 22, 768, DateTimeKind.Local).AddTicks(3309)),
                    MaKh = table.Column<Guid>(nullable: false),
                    NgườiNhận = table.Column<string>(name: "Người Nhận", maxLength: 50, nullable: false),
                    Địachỉ = table.Column<string>(name: "Địa chỉ", maxLength: 300, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SốĐT = table.Column<string>(name: "Số ĐT", maxLength: 20, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.MaDh);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayBD = table.Column<DateTime>(nullable: false),
                    NgayKT = table.Column<DateTime>(nullable: false),
                    ApplyForAll = table.Column<bool>(nullable: false),
                    DiscountPercent = table.Column<int>(nullable: true),
                    DiscountAmount = table.Column<decimal>(nullable: true),
                    ProductIds = table.Column<string>(nullable: true),
                    ProductCategoryIds = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayThanhToan = table.Column<DateTime>(nullable: false),
                    ExternalTransactionId = table.Column<string>(nullable: true),
                    TongTien = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    Result = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Provider = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    MaSp = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TênSảnPhẩm = table.Column<string>(name: "Tên Sản Phẩm", maxLength: 100, nullable: false),
                    NhanHieu = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<string>(nullable: true),
                    Gia = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false, defaultValue: 0),
                    XuatXu = table.Column<string>(nullable: true),
                    TgPhatHanh = table.Column<DateTime>(nullable: true),
                    NongDo = table.Column<string>(nullable: true),
                    NhaPC = table.Column<string>(nullable: true),
                    NhomHuong = table.Column<string>(nullable: true),
                    PhongCach = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    MauSac = table.Column<string>(nullable: true),
                    BoSuuTap = table.Column<string>(nullable: true),
                    HuongDacTrung = table.Column<string>(nullable: true),
                    Anh = table.Column<string>(nullable: true),
                    MaDM = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.MaSp);
                    table.ForeignKey(
                        name: "FK_SanPhams_DanhMucs_MaDM",
                        column: x => x.MaDM,
                        principalTable: "DanhMucs",
                        principalColumn: "MaDm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnhSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    SortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnhSanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhams_ProductId",
                        column: x => x.ProductId,
                        principalTable: "SanPhams",
                        principalColumn: "MaSp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuans",
                columns: table => new
                {
                    MaBL = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HọTên = table.Column<string>(name: "Họ Tên", maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Nộidung = table.Column<string>(name: "Nội dung", maxLength: 1000, nullable: true),
                    ThờiGian = table.Column<DateTime>(name: "Thời Gian", nullable: true),
                    ProductMaSp = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuans", x => x.MaBL);
                    table.ForeignKey(
                        name: "FK_BinhLuans_SanPhams_ProductMaSp",
                        column: x => x.ProductMaSp,
                        principalTable: "SanPhams",
                        principalColumn: "MaSp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDhs",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    ThanhTien = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDhs", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ChiTietDhs_DonHangs_OrderId",
                        column: x => x.OrderId,
                        principalTable: "DonHangs",
                        principalColumn: "MaDh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDhs_SanPhams_ProductId",
                        column: x => x.ProductId,
                        principalTable: "SanPhams",
                        principalColumn: "MaSp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    TongTien = table.Column<decimal>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangs_SanPhams_ProductId",
                        column: x => x.ProductId,
                        principalTable: "SanPhams",
                        principalColumn: "MaSp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_ProductId",
                table: "AnhSanPhams",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_ProductMaSp",
                table: "BinhLuans",
                column: "ProductMaSp");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDhs_ProductId",
                table: "ChiTietDhs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_ProductId",
                table: "GioHangs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaDM",
                table: "SanPhams",
                column: "MaDM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnhSanPhams");

            migrationBuilder.DropTable(
                name: "BinhLuans");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "ChiTietDhs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "DanhMucs");
        }
    }
}
