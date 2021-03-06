using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPhams");

            builder.HasKey(x => x.MaSp);

            builder.Property(x => x.MaSp).UseIdentityColumn();

            builder.Property(x => x.Gia).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.TenSp).IsRequired().HasMaxLength(100).HasColumnName("Tên Sản Phẩm");

            builder.HasOne(x => x.DanhMuc).WithMany(x => x.Products).HasForeignKey(x => x.MaDM);
        }
    }
}
