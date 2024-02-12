using CryptoScanner.App.ApiModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.App.ApiService
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }
        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/coins/");
        }


        public async Task<Root> MakeCallByCryptoName(string cryptoName)
        {

            HttpResponseMessage response = await Client.GetAsync($"{cryptoName}?localization=false&tickers=false&community_data=false&developer_data=false&sparkline=false");

            if(response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Root? result = JsonConvert.DeserializeObject<Root>(json);
                if (result != null)
                {
                    return result;
                }
            }
            throw new HttpRequestException();
        }
    }
}
