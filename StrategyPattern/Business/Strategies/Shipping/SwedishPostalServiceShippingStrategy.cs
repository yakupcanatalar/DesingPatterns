using System;
using System.Net.Http;
using StrategyPattern.Business.Models;

namespace StrategyPattern.Business.Strategies.Shipping
{
    public class SwedishPostalServiceShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                /// TODO: Implement PostNord Shipping Integration
                
                Console.WriteLine("Order is shipped with PostNord");
            }
        }
    }
}
