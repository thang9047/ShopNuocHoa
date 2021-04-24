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

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.TenDm).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
