using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{

    public class IndexModel : PageModel
    {
        public enum CryptoType
        {
            Bitcoin,
            Ethereum,
            Tether,
            Binancecoin,
            Solana,
        };
        public void OnGet()
        {


        }




    }
}
