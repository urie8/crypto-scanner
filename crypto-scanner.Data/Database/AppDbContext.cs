using crypto_scanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace crypto_scanner.Data.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<RootCoin> Coins { get; set; }
    }
}

