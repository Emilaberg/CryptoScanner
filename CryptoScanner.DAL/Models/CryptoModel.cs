using System.ComponentModel.DataAnnotations;

namespace CryptoScanner.DAL.Models
{
    public class CryptoModel
    {
        [Key]
        public int Id { get; set; }
        public double? Price_In_Usd { get; set; }
        public string? Name { get; set; }
        public double? Market_Cap_Rank { get; set; }
        public double? Usd_High_24H { get; set; }
        public double? Usd_Low_24H { get; set; }
        public string? Description { get; set; }
        public double? Ath { get; set; }
    }

    //public class Platforms
    //{

    //}
}
