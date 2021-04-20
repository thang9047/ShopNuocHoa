using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class SanPhamAnhConfig : IEntityTypeConfiguration<SanPhamAnh>
    {
        public void Configure(EntityTypeBuilder<SanPhamAnh> builder)
        {
            builder.ToTable("AnhSanPhams");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.Products).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductId);
        }
    }
}
