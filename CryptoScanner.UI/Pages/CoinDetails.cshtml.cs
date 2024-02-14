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
        public double? Price_In_Usd { get; set; }
        [BindProperty]
        public string? Name { get; set; }
        [BindProperty]
        public double? Market_Cap_Rank { get; set; }
        [BindProperty]
        public double? Usd_High_24H { get; set; }
        [BindProperty]
        public double? Usd_Low_24H { get; set; }
        [BindProperty]
        public string? Description { get; set; }
        [BindProperty]
        public double? Ath { get; set; }

        public async Task OnGetAsync(string name)
        {

            Root Crypto = await new ApiCaller().MakeCallByCryptoName(name);

            Price_In_Usd = Crypto.market_data.Current_price.Usd;
            Name = Crypto.Name;
            Market_Cap_Rank = Crypto.Market_cap_rank;
            Usd_High_24H = Crypto.market_data.High_24h.Usd;
            Usd_Low_24H = Crypto.market_data.Low_24h.Usd;
            Description = Crypto.Description.En;
            Ath = Crypto.market_data.Ath.Usd;




        }


        public async Task<IActionResult> OnPost()
        {


            CryptoModel newCrypto = new CryptoModel
            {
                Price_In_Usd = Price_In_Usd,
                Name = Name,
                Market_Cap_Rank = Market_Cap_Rank,
                Usd_High_24H = Usd_High_24H,
                Usd_Low_24H = Usd_Low_24H,
                Description = Description,
                Ath = Ath,
            };

            CryptoScannerService scanner = new(_Context);



            string returnstring = await scanner.AddCryptoToDb(newCrypto);
            if (returnstring == "success")
            {
                return RedirectToPage("/index");
            }

            return Page();

            //}
            //public async Task GetCrypto()
            //{

        }
    }
}
