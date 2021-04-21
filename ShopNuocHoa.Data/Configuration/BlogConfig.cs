using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Configuration
{
    public class BlogConfig : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");

            builder.HasKey(x => x.MaBlog);

            builder.Property(x => x.NoiDung).HasMaxLength(3000).IsRequired().HasColumnName("Nội dung");

            builder.Property(x => x.Anh).IsRequired().HasMaxLength(100).HasColumnName("Ảnh");

            builder.Property(x => x.TieuDe).HasMaxLength(500).HasColumnName("Tiêu Đề");
        }
    }
}
