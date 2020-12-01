using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace kShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<KshopDbContext>
    {
        public KshopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("kShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<KshopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new KshopDbContext(optionsBuilder.Options);
        }
    }
}
