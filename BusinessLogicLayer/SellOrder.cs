﻿using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SellOrder
    {
        public long? Id { get; set; }
        public DateTimeOffset? SellDate { get; set; }
        public decimal? SellPrice { get; set; }
        public long? NumbersToSell { get; set; }
        public string SellComment { get; set; }

        public SellOrder()
        {
            Reset();
        }

        private void Reset()
        {
            Id = null;
            NumbersToSell = null;
            SellComment = string.Empty;
            SellDate = null;
            SellPrice = null;
        }

        public SellOrder(SellOrders order)
        {
            if (order == null)
            {
                Reset();
            }
            else
            {
                Id = order.Id;
                NumbersToSell = order.NumbersToSell;
                SellComment = order.SellComment;
                SellDate = order.SellDate;
                SellPrice = order.SellPrice;
            }
        }

        public static SellOrder[] LoadAll()
        {
            
            var sellOrders = SellOrders.FindAll();

            var result = EntitiesToLogicUnit(sellOrders);
            return result;
        }

        private static SellOrder[] EntitiesToLogicUnit(SellOrders[] sellOrders)
        {
            var sellOrdersList = new List<SellOrder>();
            if (sellOrders != null)
                foreach (var order in sellOrders)
                {
                    var sellOrder = new SellOrder(order);
                    sellOrdersList.Add(sellOrder);
                }

            var result = sellOrdersList.ToArray();
            return result;
        }

        public void Sell()
        {

            SellDate = DateTimeOffset.Now;

            var buyOrders = BuyOrder.GetWithPriceGreaterOrEqual(SellPrice);
            if (buyOrders != null)
            {
                foreach (var buyOrder in buyOrders)
                {
                    var numbersToSell = NumbersToSell;

                    if (buyOrder != null && numbersToSell > 0)
                    {
                        var numbersToBuy = buyOrder.NumbersToBuy;

                        var numbersToTransaction = numbersToSell < numbersToBuy ? numbersToSell : numbersToBuy;
                        numbersToSell -= numbersToTransaction;
                        numbersToBuy -= numbersToTransaction;

                        var transaction = new Transaction
                        {
                            BuyDate = buyOrder.BuyDate,
                            SellDate = SellDate,
                            BuyComment = buyOrder.BuyComment,
                            SellComment = SellComment,
                            CompleteDate = DateTimeOffset.Now,
                            NumbersToTransaction = numbersToTransaction,
                            TransactionPrice = SellPrice
                        };
                        transaction.Add();

                        NumbersToSell = numbersToSell;
                        buyOrder.NumbersToBuy = numbersToBuy;

                        buyOrder.Save();
                    }
                }
            }

            if (NumbersToSell > 0)
            {
                Add();
            }
        }

        private void Add()
        {
            var newOrder = new SellOrders
            {
                SellComment = SellComment,
                SellDate = DateTimeOffset.Now,
                SellPrice = SellPrice,
                NumbersToSell = NumbersToSell
            };

            newOrder.Insert();
        }

        public static SellOrder[] GetWithPriceLessOrEqual(decimal? buyPrice)
        {
            var sellOrders = new SellOrders {SellPrice = buyPrice};
            var ordersWithPriceLessOrEqual =  sellOrders.GetWithPriceLessOrEqual();

            var result = EntitiesToLogicUnit(ordersWithPriceLessOrEqual);
            return result;
        }

        public void Save()
        {
            var instance = new SellOrders
            {
                SellPrice = SellPrice,
                Id = Id,
                NumbersToSell = NumbersToSell,
                SellComment = SellComment,
                SellDate = SellDate
            };
            instance.Update();
        }
    }
}