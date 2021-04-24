using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopNuocHoa.Data.Configuration;
using ShopNuocHoa.Data.Entities;
using ShopNuocHoa.Data.ModelBuilderExtension;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.EF
{
    public class ShopNuocHoaDBContext : IdentityDbContext<User, Role, Guid>
    {
        public ShopNuocHoaDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BinhLuanConfig());
            modelBuilder.ApplyConfiguration(new BlogConfig());
            modelBuilder.ApplyConfiguration(new ChiTietDhConfig());
            modelBuilder.ApplyConfiguration(new DanhMucConfig());
            modelBuilder.ApplyConfiguration(new DonHangConfig());
            modelBuilder.ApplyConfiguration(new GioHangConfig());
            modelBuilder.ApplyConfiguration(new KhuyenMaiConfig());
            modelBuilder.ApplyConfiguration(new LienHeConfig());
            modelBuilder.ApplyConfiguration(new SanPhamAnhConfig());
            modelBuilder.ApplyConfiguration(new SanPhamConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles").HasKey(x=> new { x.RoleId, x.UserId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(x=>x.UserId);

            //Data seeding
            modelBuilder.Seed();
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietDh> ChiTietDhs { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BinhLuan> BinhLuans { get; set; }

    }
}
