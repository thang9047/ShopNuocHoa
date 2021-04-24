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

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NgayLap).HasColumnName("Ngày lập").HasDefaultValue(DateTime.Now);

            builder.Property(x => x.NguoiNhan).IsRequired().HasMaxLength(50);

            builder.Property(x => x.DiaChiGiaoHang).IsRequired().HasMaxLength(300);

            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.SDT).IsRequired().HasMaxLength(20);

            builder.HasOne(x => x.User).WithMany(x => x.DonHangs).HasForeignKey(x => x.UserId);
        }
    }
}
