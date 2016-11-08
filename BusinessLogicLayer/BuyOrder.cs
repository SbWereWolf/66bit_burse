using System;
using System.Collections;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BuyOrder
    {
        public long? Id { get; set; }
        public DateTimeOffset? BuyDate { get; set; }
        public decimal? BuyPrice { get; set; }
        public long? NumbersToBuy { get; set; }
        public string BuyComment { get; set; }

        public BuyOrder()
        {
            Reset();
        }

        private void Reset()
        {
            Id = null;
            NumbersToBuy = null;
            BuyComment = string.Empty;
            BuyDate = null;
            BuyPrice = null;
        }

        public BuyOrder(BuyOrders order)
        {
            if (order == null)
            {
                Reset();
            }
            else
            {
                Id = order.Id;
                NumbersToBuy = order.NumbersToBuy;
                BuyComment = order.BuyComment;
                BuyDate = order.BuyDate;
                BuyPrice = order.BuyPrice;
            }
        }

        public static BuyOrder[] LoadAll()
        {

            var buyOrders = BuyOrders.FindAll();

            var buyOrdersList = new List<BuyOrder>();
            if (buyOrders != null)
                foreach (var order in buyOrders)
                {
                    var buyOrder = new BuyOrder(order);
                    buyOrdersList.Add(buyOrder);
                }

            var result = buyOrdersList.ToArray();
            return result;
        }

        public void Buy()
        {
            BuyDate = DateTimeOffset.Now;

            var sellOrders = SellOrder.GetWithPriceLessOrEqual(BuyPrice);
            if (sellOrders != null)
            {
                foreach (var sellOrder in sellOrders)
                {
                    var numbersToBuy = NumbersToBuy;

                    if (sellOrder != null && numbersToBuy > 0 )
                    {
                        var numbersToSell = sellOrder.NumbersToSell;

                        var numbersToTransaction = numbersToBuy < numbersToSell ? numbersToBuy : numbersToSell;
                        numbersToSell -= numbersToTransaction;
                        numbersToBuy -= numbersToTransaction;

                        var transaction = new Transaction
                        {
                            BuyDate = BuyDate,
                            SellDate = sellOrder.SellDate,
                            BuyComment = BuyComment,
                            SellComment = sellOrder.SellComment,
                            CompleteDate = DateTimeOffset.Now,
                            NumbersToTransaction = numbersToTransaction,
                            TransactionPrice = sellOrder.SellPrice
                        };
                        transaction.Add();

                        NumbersToBuy = numbersToBuy;
                        sellOrder.NumbersToSell = numbersToSell;

                        sellOrder.Save();
                    }
                }
            }

            if (NumbersToBuy > 0 )
            {
                Add();
            }
        }

        private void Add()
        {
            var newOrder = new BuyOrders
            {
                BuyComment = BuyComment,
                BuyDate = DateTimeOffset.Now,
                BuyPrice = BuyPrice,
                NumbersToBuy = NumbersToBuy
            };

            newOrder.Insert();
        }

        public static BuyOrder[] GetWithPriceGreaterOrEqual(decimal? sellPrice)
        {
            var buyOrders = new BuyOrders { BuyPrice = sellPrice };
            var ordersWithPriceGreaterOrEqual = buyOrders.GetWithPriceLessOrEqual();

            var result = EntitiesToLogicUnit(ordersWithPriceGreaterOrEqual);
            return result;
        }

        private static BuyOrder[] EntitiesToLogicUnit(BuyOrders[] buyOrders)
        {
            var buyOrdersList = new List<BuyOrder>();
            if (buyOrders != null)
                foreach (var order in buyOrders)
                {
                    var buyOrder = new BuyOrder(order);
                    buyOrdersList.Add(buyOrder);
                }

            var result = buyOrdersList.ToArray();
            return result;
        }

        public void Save()
        {
            var instance = new BuyOrders
            {
                BuyPrice = BuyPrice,
                Id = Id,
                NumbersToBuy = NumbersToBuy,
                BuyComment = BuyComment,
                BuyDate = BuyDate
            };
            instance.Update();
        }
    }
}