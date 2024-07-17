using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{

    /// <summary>
    /// Concrete Decorator.
    /// </summary>
    public class GiftWrap : ProductDecorator
    {
        public GiftWrap(Product product) : base(product){}

        public override string GetDescription() => base.GetDescription() + ", Gift Wrapped";
        public override double GetCost() => base.GetCost() + 5.00;
    }
}
