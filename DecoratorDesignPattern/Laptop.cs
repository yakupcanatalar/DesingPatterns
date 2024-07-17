using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    /// <summary>
    /// Concrete Component
    /// </summary>
    public class Laptop : Product
    {
        public override string GetDescription() => "Laptop";
        public override double GetCost() => 1000.00;
    }
}
