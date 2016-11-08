using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using BusinessLogicLayer;

namespace Burse.Models
{
    public class BurseItemOverview
    {
        public static string NameOfBuyPrice { get; } = "BuyPrice";
        public static string NameOfNumbersToBuy { get; } = "NumbersToBuy";
        public static string NameOfBuyComment { get; } = "BuyComment";
        public static string NameOfAddBuyOrder { get; } = "AddBuyOrder";
        public static string NameOfSellPrice { get; } = "SellPrice";
        public static string NameOfNumbersToSell { get; } = "NumbersToSell";
        public static string NameOfSellComment { get; } = "SellComment";
        public static string NameOfAddSellOrder { get; } = "AddSellOrder";

        public string BuyPrice { get; set; }
        public  string NumbersToBuy { get; set; }
        public  string BuyComment { get; set; }
        public  string AddBuyOrder { get; set; }
        public  string SellPrice { get; set; }
        public  string NumbersToSell { get; set; }
        public  string SellComment { get; set; }
        public  string AddSellOrder { get; set; }


        public BurseTransaction[] BurseTransactions { get; set; }
        public BuyOrder[] BuyOrders { get; set; }
        public SellOrder[] SellOrders { get; set; }

        public string EventMessage { get; set; }

        public BurseItemOverview(NameValueCollection requestForm)
        {

            if (requestForm != null )
            {
                BuyPrice = requestForm[NameOfBuyPrice];
                NumbersToBuy = requestForm[NameOfNumbersToBuy]; 
                BuyComment = requestForm[NameOfBuyComment];
                AddBuyOrder = requestForm[NameOfAddBuyOrder];
                SellPrice = requestForm[NameOfSellPrice];
                NumbersToSell = requestForm[NameOfNumbersToSell];
                SellComment = requestForm[NameOfSellComment];
                AddSellOrder = requestForm[NameOfAddSellOrder];
            }


            var transactions = new List<BurseTransaction>();
            var buyOrders = new List<BuyOrder>();
            var sellOrders = new List<SellOrder>();

            transactions.Add(new BurseTransaction
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

            transactions.Add(new BurseTransaction
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


            transactions.Add(new BurseTransaction
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

            transactions.Add(new BurseTransaction
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

            transactions.Add(new BurseTransaction
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

            BurseTransactions = transactions.ToArray();
            BuyOrders = buyOrders.ToArray();
            SellOrders = sellOrders.ToArray();
        }

        public void Boot()
        {
            BurseTransactions = BurseTransaction.LoadAll();
            BuyOrders = BuyOrder.LoadAll();
            SellOrders = SellOrder.LoadAll();

        }
    }
}