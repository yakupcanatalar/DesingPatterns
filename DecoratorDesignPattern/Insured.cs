using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class Insured : ProductDecorator
    {
        public Insured(Product product) : base(product)
        {
        }

        public override double GetCost() => base.GetCost() + 15.00;

        public override string GetDescription() => base.GetDescription() + ", Insured Shipping";
    }
}

//Bu dekoratör sınıfları, ProductDecorator sınıfından türetilmiştir ve ek özellikler ekler:

//  GiftWrap: Ürüne hediye paketi ekler.
//  ExpressShipping: Ürüne ekspres kargo ekler.
//  InsuredShipping: Ürüne sigortalı kargo ekler.
