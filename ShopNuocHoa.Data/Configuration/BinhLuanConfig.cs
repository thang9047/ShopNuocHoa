using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class BinhLuanConfig : IEntityTypeConfiguration<BinhLuan>
    {
        
        public void Configure(EntityTypeBuilder<BinhLuan> builder)
        {
            builder.ToTable("BinhLuans");
            builder.HasKey(x => x.MaBL);

            builder.Property(x => x.HoTen).IsRequired().HasMaxLength(50).HasColumnName("Họ Tên");

            builder.Property(x => x.Email).IsRequired().HasMaxLength(50).HasColumnName("Email");

            builder.Property(x => x.NoiDung).HasMaxLength(1000).HasColumnName("Nội dung");

            builder.Property(x => x.ThoiGian).HasColumnName("Thời Gian");
        }
    }
}
