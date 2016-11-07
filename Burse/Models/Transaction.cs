using System;

namespace Burse.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public DateTime CompleteDate { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime SellDate { get; set; }
        public decimal TransactionPrice { get; set; }
        public long NumbersToTransaction { get; set; }
        public string BuyComment { get; set; }
        public string SellComment { get; set; }
    }
}