using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using BusinessLogicLayer;

namespace Burse.Models
{
    public class BurseItemOverview
    {
        public static string NameOfBuyPrice { get; } = "FieldBuyPrice";
        public static string NameOfNumbersToBuy { get; } = "FieldNumbersToBuy";
        public static string NameOfBuyComment { get; } = "FieldBuyComment";
        public static string NameOfAddBuyOrder { get; } = "FieldAddBuyOrder";
        public static string NameOfSellPrice { get; } = "FieldSellPrice";
        public static string NameOfNumbersToSell { get; } = "FieldNumbersToSell";
        public static string NameOfSellComment { get; } = "FieldSellComment";
        public static string NameOfAddSellOrder { get; } = "FieldAddSellOrder";

        public string FieldBuyPrice { get; set; }
        public  string FieldNumbersToBuy { get; set; }
        public  string FieldBuyComment { get; set; }
        public  string FieldAddBuyOrder { get; set; }
        public  string FieldSellPrice { get; set; }
        public  string FieldNumbersToSell { get; set; }
        public  string FieldSellComment { get; set; }
        public  string FieldAddSellOrder { get; set; }


        public BurseTransaction[] BurseTransactions { get; set; }
        public BuyOrder[] BuyOrders { get; set; }
        public SellOrder[] SellOrders { get; set; }

        public string EventMessage { get; set; }

        public BurseItemOverview(NameValueCollection requestForm)
        {

            if (requestForm != null )
            {
                FieldBuyPrice = requestForm[NameOfBuyPrice];
                FieldNumbersToBuy = requestForm[NameOfNumbersToBuy]; 
                FieldBuyComment = requestForm[NameOfBuyComment];
                FieldAddBuyOrder = requestForm[NameOfAddBuyOrder];
                FieldSellPrice = requestForm[NameOfSellPrice];
                FieldNumbersToSell = requestForm[NameOfNumbersToSell];
                FieldSellComment = requestForm[NameOfSellComment];
                FieldAddSellOrder = requestForm[NameOfAddSellOrder];
            }


            var transactions = new List<BurseTransaction>();
            var buyOrders = new List<BuyOrder>();
            var sellOrders = new List<SellOrder>();

            transactions.Add(new BurseTransaction
            {
                BuyComment = "WTB !!",
                CompleteDate = new DateTime(42,01,23,0,0,6),
                BuyDate = new DateTime(42, 01, 22,23,45,56),
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

        public void AddBuyOrder()
        {
            var isAddBuyOrder = string.IsNullOrWhiteSpace(FieldAddBuyOrder);
            if (isAddBuyOrder)
            {
                var buyOrder = new BuyOrder
                {
                    BuyComment = FieldBuyComment
                };

                decimal fieldBuyPrice;
                var isSuccess = decimal.TryParse(FieldBuyPrice,NumberStyles.Float,CultureInfo.InvariantCulture,out fieldBuyPrice);
                buyOrder.BuyPrice = isSuccess ? fieldBuyPrice : (decimal?)null ;

                long numbersToBuy;
                isSuccess = long.TryParse(FieldNumbersToBuy, NumberStyles.Integer,CultureInfo.InvariantCulture,out numbersToBuy);
                buyOrder.NumbersToBuy = isSuccess ? numbersToBuy : (long?) null;

                if (fieldBuyPrice != 0 && numbersToBuy != 0 )
                {
                    buyOrder.Buy();
                }
            }
        }
        public void AddSellOrder()
        {
            var isAddSellOrder = string.IsNullOrWhiteSpace(FieldAddSellOrder);
            if (isAddSellOrder)
            {
                var sellOrder = new SellOrder
                {
                    SellComment = FieldSellComment
                };

                decimal fieldSellPrice;
                var isSuccess = decimal.TryParse(FieldSellPrice, NumberStyles.Float, CultureInfo.InvariantCulture, out fieldSellPrice);
                sellOrder.SellPrice = isSuccess ? fieldSellPrice : (decimal?)null;

                long numbersToSell;
                isSuccess = long.TryParse(FieldNumbersToSell, NumberStyles.Integer, CultureInfo.InvariantCulture, out numbersToSell);
                sellOrder.NumbersToSell = isSuccess ? numbersToSell : (long?)null;

                if(fieldSellPrice != 0 && numbersToSell != 0)
                {
                    sellOrder.Add();
                }
            }
        }
    }
}