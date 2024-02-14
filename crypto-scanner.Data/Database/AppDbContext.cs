using crypto_scanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace crypto_scanner.Data.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<RootCoin> Coins { get; set; }
    }
    //public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    //{
    //    public AppDbContext CreateDbContext(string[] args)
    //    {
    //        // Build configuration
    //        IConfigurationRoot configuration = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettings.json")
    //            .Build();

    //        // Create options builder using SQL Server from configuration
    //        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    //        var connectionString = configuration.GetConnectionString("DbConnection");
    //        optionsBuilder.UseSqlServer(connectionString);

    //        return new AppDbContext(optionsBuilder.Options);
    //    }
    //}
    //public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    //{
    //    public DbSet<RootCoin> Coins { get; set; }
    //}

}

