using System;

namespace Burse.Models
{
    public class SellOrder
    {
        public long Id { get; set; }
        public DateTime SellDate { get; set; }
        public decimal SellPrice { get; set; }
        public long NumbersToSell { get; set; }
        public string SellComment { get; set; }
    }
}