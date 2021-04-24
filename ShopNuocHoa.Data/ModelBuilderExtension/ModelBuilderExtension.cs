using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopNuocHoa.Data.Entities;
using ShopNuocHoa.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.ModelBuilderExtension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog() {MaBlog=1 ,Anh = "1605854118.02.jpg", NoiDung = "Abc d e f sfkjsa dfjdfk" },
                new Blog() {MaBlog=2, Anh = "1600330492.4583.jpg", NoiDung = "Thắng đẹp trai nhất vũ trụ" },
                new Blog() {MaBlog=3, Anh = "1605854118.02.jpg", NoiDung = "Hôm nay trời đẹp thế nhoỏoo, ỏoooo", TieuDe = "Hí Anh Em" },
                new Blog() {MaBlog=4, Anh = "1601518960.3043.jpg", NoiDung = "Hí Anh Em", TieuDe = "Hôm nay tôi off stream :))" }
                );

            //modelBuilder.Entity<DanhMuc>().HasData(
            //    new DanhMuc() { TenDm="Nước Hoa Cho Nam", Status=Status.Active, ParentId=null, 
            //        Products=new List<SanPham>() { }
            //    }
            //    );

            var adminId = new Guid("AFC1B360-B3D3-47ED-B7FE-13623E3ADDD2");
            var roleId = new Guid("D167367D-C54E-4B3D-B56B-2F318E515EBA");

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleId,
                Name="Admin",
                NormalizedName = "Admin",
                Mota = "Admin Role"
            });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User {
                Id = adminId,
                UserName = "Admin",
                NormalizedUserName = "admin",
                Email = "soivadongbon@gmail.com",
                NormalizedEmail = "soivadongbon@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin_password"),
                SecurityStamp= string.Empty,
                FirstName = "Thang",
                LastName = "Do",
                Dob = new DateTime(1999, 11, 04)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            }) ;
            
            

            


        }
    }
}
