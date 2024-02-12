using System.ComponentModel.DataAnnotations;

namespace CryptoScanner.DAL.Models
{
    public class CryptoModel
    {
        [Key]
        public int Id { get; set; }
        public double Price_In_Usd { get; set; }
        public string Name { get; set; }
        public double Usd_Market_Cap { get; set; }
        public double Usd_24H_Vhl { get; set; }
        public double Usd_24H_Change { get; set; }
        public string? Description { get; set; }
        public double Ath { get; set; }
    }

    //public class Platforms
    //{

    //}
}
