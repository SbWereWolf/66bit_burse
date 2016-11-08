using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BurseTransaction
    {
        public long? Id { get; set; }
        public DateTime? CompleteDate { get; set; }
        public DateTime? BuyDate { get; set; }
        public DateTime? SellDate { get; set; }
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
            Id = null;
            CompleteDate = null;
            NumbersToTransaction = null;
            TransactionPrice = null;
            BuyComment = null;
            BuyDate = null;
            SellComment = null;
            SellDate = null;
        }

        public BurseTransaction(BurseTransactions deal)
        {
            if (deal == null)
            {
                Reset();
            }
            else
            {
                Id = deal.Id;
                CompleteDate = deal.CompleteDate;
                NumbersToTransaction = deal.NumbersToTransaction;
                TransactionPrice = deal.TransactionPrice;
                BuyComment = deal.BuyComment;
                BuyDate = deal.BuyDate;
                SellComment = deal.SellComment;
                SellDate = deal.SellDate;
            }
        }

        public static BurseTransaction[] LoadAll()
        {

            var transactions = BurseTransactions.FindAll();

            var transactionList = new List<BurseTransaction>();
            if (transactions != null)
                foreach (var deal in transactions)
                {
                    var transaction = new BurseTransaction(deal);
                    transactionList.Add(transaction);
                }

            var result = transactionList.ToArray();
            return result;
        }
    }
}