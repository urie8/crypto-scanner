using crypto_scanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace crypto_scanner.Data.Database
{
    public class CryptoRepo
    {
        private readonly AppDbContext _context;

        public CryptoRepo(AppDbContext context)
        {
            _context = context;
        }

        public RootCoin? GetCoinByName(string name)
        {
            return _context.Coins.FirstOrDefault(c => c.Name == name);
        }
    }
}
