using System;
using System.Collections.Generic;
using System.Linq;
using Burse.LinqToMSSql;

namespace DataAccessLayer
{
    public class BurseTransactions : MSSqlRepository
    {
        public DateTimeOffset? CompleteDate { get; set; }
        public DateTimeOffset? BuyDate { get; set; }
        public DateTimeOffset? SellDate { get; set; }
        public decimal? TransactionPrice { get; set; }
        public long? NumbersToTransaction { get; set; }
        public string BuyComment { get; set; }
        public string SellComment { get; set; }

        public BurseTransactions()
        {
            CompleteDate = null;
            BuyDate = null;
            SellDate = null;
            TransactionPrice = null;
            NumbersToTransaction = null;
            BuyComment = string.Empty;
            SellComment = string.Empty;
        }

        public BurseTransactions(BurseTransaction record)
        {
            if (record != null)
            {
                CompleteDate = record.CompleteDate;
                BuyDate = record.BuyDate;
                SellDate = record.SellDate;
                TransactionPrice = record.TransactionPrice;
                NumbersToTransaction = record.NumbersToTransaction;
                BuyComment = record.BuyComment;
                SellComment = record.SellComment;
            }
        }

        public static BurseTransactions[] FindAll()
        {
            BurseTransaction[] transactions = Repository?.BurseTransactions?.ToArray();

            var transactionsRecordsList = new List<BurseTransactions>();
            if (transactions != null)
                foreach (var record in transactions)
                {
                    var transactionsRecords = new BurseTransactions(record);
                    transactionsRecordsList.Add(transactionsRecords);
                }

            var result = transactionsRecordsList.ToArray();
            return result;
        }
    }
}