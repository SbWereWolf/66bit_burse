﻿using System;

namespace DataAccessLayer
{
    public class BuyOrders
    {
        public long Id { get; set; }
        public DateTime BuyDate { get; set; }
        public decimal BuyPrice { get; set; }
        public long NumbersToBuy { get; set; }
        public string BuyComment { get; set; }


        public static BuyOrders[] FindAll()
        {
            return null;
        }
    }
}