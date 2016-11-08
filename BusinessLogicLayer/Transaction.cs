using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Transaction
    {
        public DateTimeOffset? CompleteDate { get; set; }
        public decimal? TransactionPrice { get; set; }
        public long? NumbersToTransaction { get; set; }
        public DateTimeOffset? BuyDate { get; set; }
        public DateTimeOffset? SellDate { get; set; }
        public string BuyComment { get; set; }
        public string SellComment { get; set; }

        public Transaction()
        {
            Reset();
        }

        private void Reset()
        {
            CompleteDate = null;
            NumbersToTransaction = null;
            TransactionPrice = null;
            BuyDate = null;
            SellDate = null;
            BuyComment = null;
            SellComment = null;
        }

        public Transaction(TransactionsRecords record)
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
                BuyDate = record.BuyDate;
                SellDate = record.SellDate;
                BuyComment = record.BuyComment;
                SellComment = record.SellComment;
            }
        }

        public static Transaction[] LoadAll()
        {
            var transactions = TransactionsRecords.FindAll();

            var transactionList = new List<Transaction>();
            if (transactions != null)
                foreach (var record in transactions)
                {
                    var transaction = new Transaction(record);
                    transactionList.Add(transaction);
                }

            var result = transactionList.ToArray();
            return result;
        }
        public void Add()
        {
            var newDeal = new TransactionsRecords
            {
                CompleteDate = DateTimeOffset.Now,
                NumbersToTransaction = NumbersToTransaction,
                TransactionPrice = TransactionPrice,
                BuyDate = BuyDate,
                SellDate = SellDate,
                BuyComment = BuyComment,
                SellComment = SellComment,
            };

            newDeal.Insert();
        }
    }
}