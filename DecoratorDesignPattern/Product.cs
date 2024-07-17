using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    /*
    Bu senaryoda, bir online mağaza sipariş sistemi için bir örnek oluşturacağız. 
    Temel ürünler ve bu ürünlere eklenebilecek çeşitli özellikler (dekoratörler) olacak. 
    Örneğin, bir ürün hediye paketi ile gönderilebilir, ekspres kargo seçeneği eklenebilir veya sigortalı kargo ile gönderilebilir.

     */

    /// <summary>
    /// Component
    /// </summary>
    public abstract class Product
    {
        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
