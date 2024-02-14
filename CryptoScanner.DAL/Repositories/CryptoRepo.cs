using CryptoScanner.DAL.Database;
using CryptoScanner.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoScanner.DAL.Repositories
{
    public class CryptoRepo
    {
        private readonly AppDbContext context;
        public CryptoRepo(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<CryptoModel> GetCryptoByIdAsync(int id)
        {
            return await context.Cryptos.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CryptoModel>> GetAllCryptosAsync()
        {
            return await context.Cryptos.ToListAsync();
        }

        public async Task<CryptoModel> AddCryptoAsync(CryptoModel crypto)
        {
            if (crypto == null)
            {
                throw new NullReferenceException();
            }

            context.Cryptos.Add(crypto);
            await context.SaveChangesAsync();
            return crypto;

        }

        public async Task<CryptoModel> UpdateCryptoAsync(CryptoModel updatedCrypto)
        {
            CryptoModel cryptoToUpdate = await GetCryptoByIdAsync(updatedCrypto.Id);

            if (cryptoToUpdate == null)
            {
                throw new NullReferenceException();
            }

            cryptoToUpdate.Name = updatedCrypto.Name;
            cryptoToUpdate.Description = updatedCrypto.Description;
            cryptoToUpdate.Market_Cap_Rank = updatedCrypto.Market_Cap_Rank;
            cryptoToUpdate.Ath = updatedCrypto.Ath;
            cryptoToUpdate.Usd_High_24H = updatedCrypto.Usd_High_24H;
            cryptoToUpdate.Usd_Low_24H = updatedCrypto.Usd_Low_24H;
            cryptoToUpdate.Price_In_Usd = updatedCrypto.Price_In_Usd;

            await context.SaveChangesAsync();

            return cryptoToUpdate;


        }

        public async Task<string> DeleteCryptoAsync(CryptoModel crypto)
        {
            CryptoModel cryptoToDelete = await GetCryptoByIdAsync(crypto.Id);

            if (cryptoToDelete == null)
            {
                throw new NullReferenceException();
            }

            context.Cryptos.Remove(cryptoToDelete);
            await context.SaveChangesAsync();
            return "Crypto deleted successfully";

        }
    }
}
