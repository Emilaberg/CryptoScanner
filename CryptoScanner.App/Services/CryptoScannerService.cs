using CryptoScanner.DAL.Database;
using CryptoScanner.DAL.Models;
using CryptoScanner.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.App.Services
{
    public class CryptoScannerService : ICryptoScannerService
    {
        internal CryptoRepo cryptoRepo { get; set; }

        public CryptoScannerService(AppDbContext context)
        {
            cryptoRepo = new(context);

        }

        public async Task<List<CryptoModel>> GetAllCryptoAsync()
        {
            return await cryptoRepo.GetAllAsync();   

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
