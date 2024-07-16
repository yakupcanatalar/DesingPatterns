using StrategyPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
