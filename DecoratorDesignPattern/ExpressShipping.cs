using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class ExpressShipping : ProductDecorator
    {
        public ExpressShipping(Product product) : base(product)
        {
        }

        public override string GetDescription() => base.GetDescription() + ", Express shipping";

        public override double GetCost() => base.GetCost() + 20.00;
    }
}
