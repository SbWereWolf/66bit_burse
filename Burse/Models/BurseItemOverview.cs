using System;
using System.Collections.Generic;

namespace Burse.Models
{
    public class BurseItemOverview
    {
        public Transaction[] Transactions { get; }
        public BuyOrder[] BuyOrders { get; }
        public SellOrder[] SellOrders { get; }

        public string EventMessage { get; set; }

        public BurseItemOverview()
        {
            var transactions = new List<Transaction>();
            var buyOrders = new List<BuyOrder>();
            var sellOrders = new List<SellOrder>();

            transactions.Add(new Transaction
            {
                BuyComment = "WTB !!",
                CompleteDate = new DateTime(42,01,23,0,0,6),
                BuyDate = new DateTime(42, 01, 22,23,45,56),
                Id = 1,
                NumbersToTransaction = 12,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22,23,59,59),
                TransactionPrice = 20
            });

            buyOrders.Add(new BuyOrder
            {
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 2,
                BuyComment = "WTB !!",
                BuyPrice = 25,
                NumbersToBuy = 3
            });

            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });

            transactions.Add(new Transaction
            {
                BuyComment = "WTB !!",
                CompleteDate = new DateTime(42, 01, 23, 0, 0, 6),
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 1,
                NumbersToTransaction = 12,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                TransactionPrice = 20
            });

            buyOrders.Add(new BuyOrder
            {
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 2,
                BuyComment = "WTB !!",
                BuyPrice = 25,
                NumbersToBuy = 3
            });

            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });


            transactions.Add(new Transaction
            {
                BuyComment = "WTB !!",
                CompleteDate = new DateTime(42, 01, 23, 0, 0, 6),
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 1,
                NumbersToTransaction = 12,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                TransactionPrice = 20
            });

            buyOrders.Add(new BuyOrder
            {
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 2,
                BuyComment = "WTB !!",
                BuyPrice = 25,
                NumbersToBuy = 3
            });

            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });

            transactions.Add(new Transaction
            {
                BuyComment = "WTB !!",
                CompleteDate = new DateTime(42, 01, 23, 0, 0, 6),
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 1,
                NumbersToTransaction = 12,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                TransactionPrice = 20
            });

            buyOrders.Add(new BuyOrder
            {
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 2,
                BuyComment = "WTB !!",
                BuyPrice = 25,
                NumbersToBuy = 3
            });

            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });

            transactions.Add(new Transaction
            {
                BuyComment = "WTB !!",
                CompleteDate = new DateTime(42, 01, 23, 0, 0, 6),
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 1,
                NumbersToTransaction = 12,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                TransactionPrice = 20
            });

            buyOrders.Add(new BuyOrder
            {
                BuyDate = new DateTime(42, 01, 22, 23, 45, 56),
                Id = 2,
                BuyComment = "WTB !!",
                BuyPrice = 25,
                NumbersToBuy = 3
            });

            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });


            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });

            sellOrders.Add(new SellOrder
            {
                Id = 1,
                SellComment = "wts",
                SellDate = new DateTime(42, 01, 22, 23, 59, 59),
                NumbersToSell = 1,
                SellPrice = 20
            });

            Transactions = transactions.ToArray();
            BuyOrders = buyOrders.ToArray();
            SellOrders = sellOrders.ToArray();
        }
    }
}