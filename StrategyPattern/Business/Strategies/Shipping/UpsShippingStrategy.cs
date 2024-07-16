﻿using System;
using System.Net.Http;
using StrategyPattern.Business.Models;

namespace StrategyPattern.Business.Strategies.Shipping
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                /// TODO: Implement UPS Shipping Integration

                Console.WriteLine("Order is shipped with UPS");
            }
        }
    }
}
