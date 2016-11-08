using System;
using System.Collections.Generic;
using System.Linq;
using Burse.LinqToMSSql;

namespace DataAccessLayer
{
    public class TransactionsRecords : MSSqlRepository
    {
        public long? Id { get; set; }
        public DateTimeOffset? CompleteDate { get; set; }
        public DateTimeOffset? BuyDate { get; set; }
        public DateTimeOffset? SellDate { get; set; }
        public string BuyComment { get; set; }
        public string SellComment { get; set; }

        public decimal? TransactionPrice { get; set; }
        public long? NumbersToTransaction { get; set; }

        public TransactionsRecords()
        {
            Id = null;
            CompleteDate = null;
            TransactionPrice = null;
            NumbersToTransaction = null;
            BuyDate = null;
            SellDate = null;
            BuyComment = string.Empty;
            SellComment = string.Empty;
        }


        public TransactionsRecords(BurseTransaction deal)
        {
            if (deal != null)
            {
                Id = deal.Id;
                CompleteDate = deal.CompleteDate;
                TransactionPrice = deal.TransactionPrice;
                NumbersToTransaction = deal.NumbersToTransaction;
                BuyDate = deal.BuyDate;
                SellDate = deal.SellDate;
                BuyComment = deal.BuyComment;
                SellComment = deal.SellComment;
            }
        }

        public static TransactionsRecords[] FindAll()
        {
            var transactions = Repository?.BurseTransactions?.ToArray();

            var transactionsRecordsList = new List<TransactionsRecords>();
            if (transactions != null)
                foreach (var deal in transactions)
                {
                    var transactionsRecords = new TransactionsRecords(deal);
                    transactionsRecordsList.Add(transactionsRecords);
                }

            var result = transactionsRecordsList.ToArray();
            return result;
        }

        public void Insert()
        {
            var deal = new BurseTransaction
            {
                CompleteDate = CompleteDate,
                NumbersToTransaction = NumbersToTransaction,
                TransactionPrice = TransactionPrice,
                BuyDate = BuyDate,
                SellDate = SellDate,
                BuyComment = BuyComment,
                SellComment = SellComment
            };

            Repository?.BurseTransactions?.InsertOnSubmit(deal);
            Repository?.BurseTransactions?.Context?.SubmitChanges();

            Id = deal.Id;
        }
    }
}