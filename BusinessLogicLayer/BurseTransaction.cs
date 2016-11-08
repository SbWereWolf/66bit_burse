using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BurseTransaction
    {
        public DateTimeOffset? CompleteDate { get; set; }
        public DateTimeOffset? BuyDate { get; set; }
        public DateTimeOffset? SellDate { get; set; }
        public decimal? TransactionPrice { get; set; }
        public long? NumbersToTransaction { get; set; }
        public string BuyComment { get; set; }
        public string SellComment { get; set; }

        public BurseTransaction()
        {
            Reset();
        }

        private void Reset()
        {
            CompleteDate = null;
            NumbersToTransaction = null;
            TransactionPrice = null;
            BuyComment = null;
            BuyDate = null;
            SellComment = null;
            SellDate = null;
        }

        public BurseTransaction(BurseTransactions record)
        {
            if (record == null)
            {
                Reset();
            }
            else
            {
                CompleteDate = record.CompleteDate;
                NumbersToTransaction = record.NumbersToTransaction;
                TransactionPrice = record.TransactionPrice;
                BuyComment = record.BuyComment;
                BuyDate = record.BuyDate;
                SellComment = record.SellComment;
                SellDate = record.SellDate;
            }
        }

        public static BurseTransaction[] LoadAll()
        {
            var transactions = BurseTransactions.FindAll();

            var transactionList = new List<BurseTransaction>();
            if (transactions != null)
                foreach (var record in transactions)
                {
                    var transaction = new BurseTransaction(record);
                    transactionList.Add(transaction);
                }

            var result = transactionList.ToArray();
            return result;
        }
    }
}