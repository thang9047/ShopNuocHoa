using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class ChiTietDhConfig : IEntityTypeConfiguration<ChiTietDh>
    {
        public void Configure(EntityTypeBuilder<ChiTietDh> builder)
        {
            builder.ToTable("ChiTietDhs");

            builder.HasKey(x => new { x.OrderId, x.ProductId });

            builder.HasOne(t => t.SanPham).WithMany(ct => ct.OrderDetails).HasForeignKey(ct => ct.ProductId);

            builder.HasOne(t => t.DonHang).WithMany(ct => ct.OrderDetails).HasForeignKey(ct => ct.OrderId);
        }
    }
}
