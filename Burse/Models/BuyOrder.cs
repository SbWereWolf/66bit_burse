using System;

namespace Burse.Models
{
    public class BuyOrder
    {
        public long Id { get; set; }
        public DateTime BuyDate { get; set; }
        public decimal BuyPrice { get; set; }
        public long NumbersToBuy { get; set; }
        public string BuyComment { get; set; }
    }
}