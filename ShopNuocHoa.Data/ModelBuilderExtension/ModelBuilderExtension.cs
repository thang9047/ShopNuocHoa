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



        }
    }
}
