using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace Burse.Models
{
    public class BuyOrder
    {
        public long? Id { get; set; }
        public DateTime? BuyDate { get; set; }
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
    }
}