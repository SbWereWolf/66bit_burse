using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SellOrder
    {
        public long? Id { get; set; }
        public DateTime? SellDate { get; set; }
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

            var sellOrdersList = new List<SellOrder>();
            if (sellOrders != null)
                foreach (var order in sellOrders)
                {
                    var sellOrder  = new SellOrder(order);
                    sellOrdersList.Add(sellOrder);
                }

            var result = sellOrdersList.ToArray();
            return result;
        }
    }
}