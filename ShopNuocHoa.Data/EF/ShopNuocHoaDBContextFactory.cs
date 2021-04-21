using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopNuocHoa.Data.EF
{
    public class ShopNuocHoaDBContextFactory : IDesignTimeDbContextFactory<ShopNuocHoaDBContext>
    {
        public ShopNuocHoaDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopNuocHoaDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopNuocHoaDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopNuocHoaDBContext(optionsBuilder.Options);
        }
    }
}
