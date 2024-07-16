using StrategyPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Business.Strategies.SalesTax
{
    public class UsaSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            switch (destination)
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}
