using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using ShopNuocHoa.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class DanhMucConfig : IEntityTypeConfiguration<DanhMuc>
    {
        public void Configure(EntityTypeBuilder<DanhMuc> builder)
        {
            builder.ToTable("DanhMucs");

            builder.HasKey(x => x.MaDm);

            builder.Property(x => x.MaDm).UseIdentityColumn();

            builder.Property(x => x.TenDm).IsRequired().HasMaxLength(100).HasColumnName("Tên DanhMuc");

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
