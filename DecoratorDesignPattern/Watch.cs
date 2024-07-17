using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    /// <summary>
    /// Concreate Component
    /// </summary>
    public class Watch : Product
    {
        public override double GetCost() => 100;

        public override string GetDescription() => "Watch";
    }
}

//Book,Watch ve Laptop sınıfları, Product sınıfından türetilmiştir ve her biri kendi açıklamasını ve maliyetini gösteriyor.