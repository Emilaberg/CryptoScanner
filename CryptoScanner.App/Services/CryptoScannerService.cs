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
        public async Task<CryptoModel> GetCryptoByIdAsync(int id)
        {
            CryptoModel? crypto = await cryptoRepo.GetCryptoByIdAsync(id);
            if (crypto == null)
            {
                throw new NullReferenceException(nameof(crypto));
            }

            return crypto;
        }

        public async Task<string> AddCryptoToDb(CryptoModel newCrypto)
        {
            CryptoModel exits = await GetCryptoByIdAsync(newCrypto.Id);

            if (exits != null)
            {
                return "crypto already exits";
            }
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
