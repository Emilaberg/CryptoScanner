using CryptoScanner.DAL.Models;

namespace CryptoScanner.App.Services
{
    public interface ICryptoScannerService
    {
        public Task<List<CryptoModel>> GetAllCryptosAsync();
        public CryptoModel GetCrypto(string name);

        public void UpdateCrypto(string name);

    }
}
