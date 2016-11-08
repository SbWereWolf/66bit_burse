using System;
using System.Collections.Generic;
using System.Linq;
using Burse.LinqToMSSql;

namespace DataAccessLayer
{
    public class SellOrders : MSSqlRepository
    {
        public long? Id { get; set; }
        public DateTimeOffset? SellDate { get; set; }
        public decimal? SellPrice { get; set; }
        public long? NumbersToSell { get; set; }
        public string SellComment { get; set; }

        public SellOrders()
        {
            Reset();
        }

        private void Reset()
        {
            Id = null;
            SellDate = null;
            SellPrice = null;
            NumbersToSell = null;
            SellComment = null;
        }


        public SellOrders(SellOrder order)
        {
            if (order == null)
            {
                Reset();
            }
            else
            {
                Id = order.Id;
                SellDate = order.SellDate;
                SellPrice = order.SellPrice;
                NumbersToSell = order.NumbersToSell;
                SellComment = order.SellComment;
            }
        }

        public static SellOrders[] FindAll()
        {
            var sellOrders = Repository?.SellOrders?.ToArray();

            var result = RecordToEntityCollection(sellOrders);
            return result;
        }

        private static SellOrders[] RecordToEntityCollection(SellOrder[] sellOrders)
        {
            var sellOrdersRecordsList = new List<SellOrders>();
            if (sellOrders != null)
                foreach (var order in sellOrders)
                {
                    var sellOrdersRecords = new SellOrders(order);
                    sellOrdersRecordsList.Add(sellOrdersRecords);
                }

            var result = sellOrdersRecordsList.ToArray();
            return result;
        }

        public void Insert()
        {
            var sellOrder = new SellOrder
            {
                SellComment = SellComment,
                SellDate = SellDate,
                SellPrice = SellPrice,
                NumbersToSell = NumbersToSell
            };

            Repository?.SellOrders?.InsertOnSubmit(sellOrder);
            Repository?.SellOrders?.Context?.SubmitChanges();

            Id = sellOrder.Id;
        }

        public SellOrders[] GetWithPriceLessOrEqual()
        {
            var sellOrders = Repository?.SellOrders?.Where( x=> x.SellPrice <= SellPrice && x.NumbersToSell > 0 ).OrderBy(x=> x.SellPrice).ThenBy(x=> x.NumbersToSell).ToArray();

            var sellOrderArray = RecordToEntityCollection(sellOrders);

            return sellOrderArray;
        }

        public bool Update()
        {
            SellOrder cache = null;
            if ( Id.HasValue)
            {
                cache = Repository?.SellOrders?.FirstOrDefault(x => x.Id == Id.Value);
            }

            var result = false;
            if (cache != null)
            {
                cache.Id = Id.Value;
                cache.NumbersToSell = NumbersToSell;
                cache.SellPrice = SellPrice;
                cache.SellComment = SellComment;
                cache.SellDate = SellDate;

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
    }
}