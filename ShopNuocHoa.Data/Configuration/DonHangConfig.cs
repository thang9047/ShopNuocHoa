using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class DonHangConfig : IEntityTypeConfiguration<DonHang>
    {
        public void Configure(EntityTypeBuilder<DonHang> builder)
        {
            builder.ToTable("DonHangs");

            builder.HasKey(x => x.MaDh);

            builder.Property(x => x.MaDh).UseIdentityColumn();

            builder.Property(x => x.NgayLap).HasColumnName("Ngày lập").HasDefaultValue(DateTime.Now);

            builder.Property(x => x.NguoiNhan).IsRequired().HasMaxLength(50).HasColumnName("Người Nhận");

            builder.Property(x => x.DiaChiGiaoHang).IsRequired().HasMaxLength(300).HasColumnName("Địa chỉ");

            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(50).HasColumnName("Email");

            builder.Property(x => x.SDT).IsRequired().HasColumnType("PhoneNumber").HasColumnName("Số ĐT").HasMaxLength(20);
        }
    }
}
