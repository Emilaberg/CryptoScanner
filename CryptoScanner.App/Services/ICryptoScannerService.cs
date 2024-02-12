using CryptoScanner.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.App.Services
{
    public interface ICryptoScannerService
    {
        public Task<List<CryptoModel>> GetAllCryptoAsync();
        public CryptoModel GetCrypto(string name);

        public void UpdateCrypto(string name);

    }
}
