using System;

namespace DataAccessLayer
{
    public class SellOrders : MSSqlRepository
    {
        public long Id { get; set; }
        public DateTime SellDate { get; set; }
        public decimal SellPrice { get; set; }
        public long NumbersToSell { get; set; }
        public string SellComment { get; set; }

        public static SellOrders[] FindAll()
        {
            return null;
        }
    }
}