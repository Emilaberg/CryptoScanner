using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.App.ApiModels
{
    public class Root
    {
        public string? Id { get; set; }
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public Description? Description { get; set; }
        public Image? image { get; set; }
        public int? Market_cap_rank { get; set; }
        public MarketData? market_data { get; set; }

    }

    public class Description
    {
        public string? En { get; set; }
    }

    public class Image
    {
        public string? Thumb { get; set; }
        public string? Small { get; set; }
        public string? Large { get; set; }
    }
    public class MarketData
    {
        public CurrentPrice? Current_price { get; set; }
        public Ath? Ath { get; set; }
        public High24h? High_24h { get; set; }
        public Low24h? Low_24h { get; set; }
    }

    public class CurrentPrice
    {
        public double? Eur { get; set; }
        public double? Usd { get; set; }
        public double? Sek { get; set; }
    }
    public class Ath
    {
        public double? Eur { get; set; }
        public double? Usd { get; set; }
        public double? Sek { get; set; }
    }

    public class High24h
    {
        public double? Eur { get; set; }
        public double? Usd { get; set; }
        public double? Sek { get; set; }
    }
    public class Low24h
    {
        public double? Eur { get; set; }
        public double? Usd { get; set; }
        public double? Sek { get; set; }
    }

}
