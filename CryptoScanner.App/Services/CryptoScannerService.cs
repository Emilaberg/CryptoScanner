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
        public async Task<CryptoModel?> GetCryptoByIdAsync(int id)
        {

            return await cryptoRepo.GetCryptoByIdAsync(id);
        }
        public async Task<CryptoModel?> GetCryptoByNameAsync(string name)
        {

            return await cryptoRepo.GetCryptoByNameAsync(name);
        }

        public async Task<string?> AddCryptoToDb(CryptoModel newCrypto)
        {
            await cryptoRepo.AddCryptoAsync(newCrypto);
            return "success";
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
