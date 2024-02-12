using System.ComponentModel.DataAnnotations;

namespace CryptoScanner.DAL.Models
{
    public class CryptoModel
    {
        [Key]
        public string Id { get; set; }
        public double Usd_Price { get; set; }
        public string Name { get; set; }
        public double Usd_Market_Cap { get; set; }
        public double Usd_24H_Vhl { get; set; }
        public double Usd_24H_Change { get; set; }
    }

    //public class Platforms
    //{

    //}
}
