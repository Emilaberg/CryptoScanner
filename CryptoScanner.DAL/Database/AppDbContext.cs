using CryptoScanner.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoScanner.DAL.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CryptoModel> Cryptos { get; set; }
    }
}
