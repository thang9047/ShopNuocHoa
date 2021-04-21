﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopNuocHoa.Data.EF;

namespace ShopNuocHoa.Data.Migrations
{
    [DbContext(typeof(ShopNuocHoaDBContext))]
    partial class ShopNuocHoaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.BinhLuan", b =>
                {
                    b.Property<int>("MaBL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnName("Họ Tên")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NoiDung")
                        .HasColumnName("Nội dung")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int?>("ProductMaSp")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ThoiGian")
                        .HasColumnName("Thời Gian")
                        .HasColumnType("datetime2");

                    b.HasKey("MaBL");

                    b.HasIndex("ProductMaSp");

                    b.ToTable("BinhLuans");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.Blog", b =>
                {
                    b.Property<int>("MaBlog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnName("Ảnh")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnName("Nội dung")
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("TieuDe")
                        .HasColumnName("Tiêu Đề")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("MaBlog");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            MaBlog = 1,
                            Anh = "1605854118.02.jpg",
                            NoiDung = "Abc d e f sfkjsa dfjdfk"
                        },
                        new
                        {
                            MaBlog = 2,
                            Anh = "1600330492.4583.jpg",
                            NoiDung = "Thắng đẹp trai nhất vũ trụ"
                        },
                        new
                        {
                            MaBlog = 3,
                            Anh = "1605854118.02.jpg",
                            NoiDung = "Hôm nay trời đẹp thế nhoỏoo, ỏoooo",
                            TieuDe = "Hí Anh Em"
                        },
                        new
                        {
                            MaBlog = 4,
                            Anh = "1601518960.3043.jpg",
                            NoiDung = "Hí Anh Em",
                            TieuDe = "Hôm nay tôi off stream :))"
                        });
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.ChiTietDh", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ChiTietDhs");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.DanhMuc", b =>
                {
                    b.Property<int>("MaDm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("TenDm")
                        .IsRequired()
                        .HasColumnName("Tên DanhMuc")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaDm");

                    b.ToTable("DanhMucs");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.DonHang", b =>
                {
                    b.Property<int>("MaDh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChiGiaoHang")
                        .IsRequired()
                        .HasColumnName("Địa chỉ")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<Guid>("MaKh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayLap")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Ngày lập")
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 4, 21, 14, 49, 24, 495, DateTimeKind.Local).AddTicks(4337));

                    b.Property<string>("NguoiNhan")
                        .IsRequired()
                        .HasColumnName("Người Nhận")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnName("Số ĐT")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("MaDh");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.GioHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.KhuyenMai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ApplyForAll")
                        .HasColumnType("bit");

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductCategoryIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.LienHe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.SanPham", b =>
                {
                    b.Property<int>("MaSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoSuuTap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HuongDacTrung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaDM")
                        .HasColumnType("int");

                    b.Property<string>("MauSac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhaPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhanHieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhomHuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NongDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhongCach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("TenSp")
                        .IsRequired()
                        .HasColumnName("Tên Sản Phẩm")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("TgPhatHanh")
                        .HasColumnType("datetime2");

                    b.Property<string>("XuatXu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSp");

                    b.HasIndex("MaDM");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.SanPhamAnh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("AnhSanPhams");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExternalTransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.BinhLuan", b =>
                {
                    b.HasOne("ShopNuocHoa.Data.Entities.SanPham", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductMaSp");
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.ChiTietDh", b =>
                {
                    b.HasOne("ShopNuocHoa.Data.Entities.DonHang", "DonHang")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopNuocHoa.Data.Entities.SanPham", "SanPham")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.GioHang", b =>
                {
                    b.HasOne("ShopNuocHoa.Data.Entities.SanPham", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.SanPham", b =>
                {
                    b.HasOne("ShopNuocHoa.Data.Entities.DanhMuc", "DanhMuc")
                        .WithMany("Products")
                        .HasForeignKey("MaDM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopNuocHoa.Data.Entities.SanPhamAnh", b =>
                {
                    b.HasOne("ShopNuocHoa.Data.Entities.SanPham", "Products")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
