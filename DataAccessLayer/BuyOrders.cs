using System;
using System.Collections.Generic;
using System.Linq;
using Burse.LinqToMSSql;

namespace DataAccessLayer
{
    public class BuyOrders : MSSqlRepository
    {
        public long? Id { get; set; }
        public DateTimeOffset? BuyDate { get; set; }
        public decimal? BuyPrice { get; set; }
        public long? NumbersToBuy { get; set; }
        public string BuyComment { get; set; }



        public BuyOrders()
        {
            Reset();
        }

        private void Reset()
        {
            Id = null;
            BuyDate = null;
            BuyPrice = null;
            NumbersToBuy = null;
            BuyComment = null;
        }


        public BuyOrders(BuyOrder order)
        {
            if (order == null)
            {
                Reset();
            }
            else
            {
                Id = order.Id;
                BuyDate = order.BuyDate;
                BuyPrice = order.BuyPrice;
                NumbersToBuy = order.NumbersToBuy;
                BuyComment = order.BuyComment;
            }
        }

        public static BuyOrders[] FindAll()
        {
            var sellOrders = Repository?.BuyOrders?.ToArray();

            var sellOrdersRecordsList = new List<BuyOrders>();
            if (sellOrders != null)
                foreach (var order in sellOrders)
                {
                    var sellOrdersRecords = new BuyOrders(order);
                    sellOrdersRecordsList.Add(sellOrdersRecords);
                }

            var result = sellOrdersRecordsList.ToArray();
            return result;
        }

        public void Insert()
        {
            var buyOrder = new BuyOrder
            {
                BuyComment = BuyComment,
                BuyDate = BuyDate,
                BuyPrice = BuyPrice,
                NumbersToBuy = NumbersToBuy
            };

            Repository?.BuyOrders?.InsertOnSubmit(buyOrder);
            Repository?.BuyOrders?.Context?.SubmitChanges();

            Id = buyOrder.Id;
        }

        public bool Update()
        {
            BuyOrder cache = null;
            if (Id.HasValue)
            {
                cache = Repository?.BuyOrders?.FirstOrDefault(x => x.Id == Id.Value);
            }

            var result = false;
            if (cache != null)
            {
                cache.Id = Id.Value;
                cache.NumbersToBuy = NumbersToBuy;
                cache.BuyPrice = BuyPrice;
                cache.BuyComment = BuyComment;
                cache.BuyDate = BuyDate;

                try
                {
                    Repository?.SubmitChanges();
                    result = true;
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            return result;
        }

        public BuyOrders[] GetWithPriceLessOrEqual()
        {
            var buyOrders = Repository?.BuyOrders?.Where(x => x.BuyPrice >= BuyPrice && x.NumbersToBuy > 0).OrderBy(x => x.BuyPrice).ThenBy(x => x.NumbersToBuy).ToArray();

            var buyOrderArray = RecordToEntityCollection(buyOrders);

            return buyOrderArray;
        }

        private BuyOrders[] RecordToEntityCollection(BuyOrder[] buyOrders)
        {
            var buyOrdersRecordsList = new List<BuyOrders>();
            if (buyOrders != null)
                foreach (var order in buyOrders)
                {
                    var buyOrdersRecords = new BuyOrders(order);
                    buyOrdersRecordsList.Add(buyOrdersRecords);
                }

            var result = buyOrdersRecordsList.ToArray();
            return result;
        }
    }
}