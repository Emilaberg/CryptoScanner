using CryptoScanner.App.ApiModels;
using CryptoScanner.App.ApiService;
using CryptoScanner.App.Services;
using CryptoScanner.DAL.Database;
using CryptoScanner.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class CoinDetailsModel : PageModel
    {
        private readonly AppDbContext _Context;

        public CoinDetailsModel(AppDbContext context)
        {
            _Context = context;


        }

        [BindProperty]
        public Root? Crypto { get; set; }

        public async Task OnGetAsync(string name)
        {
            Crypto = await new ApiCaller().MakeCallByCryptoName(name);

        }


        public async Task<IActionResult> OnPost()
        {

            CryptoModel newCrypto = new CryptoModel
            {
                Price_In_Usd = Crypto.market_data.Current_price.Usd,
                Name = Crypto.Name,
                Market_Cap_Rank = Crypto.Market_cap_rank,
                Usd_High_24H = Crypto.market_data.High_24h.Usd,
                Usd_Low_24H = Crypto.market_data.Low_24h.Usd,
                Description = Crypto.Description.En,
                Ath = Crypto.market_data.Ath.Usd,
            };

            CryptoScannerService scanner = new(_Context);



            string returnstring = await scanner.AddCryptoToDb(newCrypto);
            if (returnstring == "success")
            {
                return RedirectToPage("/index");
            }

            return Page();

        }
        //public async Task GetCrypto()
        //{

        //}
    }
}
