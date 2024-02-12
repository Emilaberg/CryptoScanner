using CryptoScanner.DAL.Database;
using CryptoScanner.DAL.Models;
using CryptoScanner.DAL.Repositories;

namespace CryptoScanner.App.Services
{
    public class CryptoScannerService : ICryptoScannerService
    {
        internal CryptoRepo cryptoRepo { get; set; }

        public CryptoScannerService(AppDbContext context)
        {
            cryptoRepo = new(context);

        }

        public async Task<List<CryptoModel>> GetAllCryptosAsync()
        {
            return await cryptoRepo.GetAllCryptosAsync();

        }

        public CryptoModel GetCrypto(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCrypto(string name)
        {
            throw new NotImplementedException();
        }
    }
}
