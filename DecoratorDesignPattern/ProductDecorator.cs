using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    /// <summary>
    /// Decorator Arayüzü
    /// </summary>
    public abstract class ProductDecorator:Product
    {
        protected Product _product;

        protected ProductDecorator(Product product)
        {
            _product = product;
        }

        public override double GetCost()=>_product.GetCost();

        public override string GetDescription()=>_product.GetDescription();


        //ProductDecorator sınıfı, Product sınıfından türetilmiştir ve
        //Product nesnesini referans alır. Bu sınıf, temel dekoratör işlevselliğini sağlar.
    }
}
