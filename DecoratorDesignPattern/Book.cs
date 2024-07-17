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
    public class Book : Product
    {
        public override string GetDescription() => "Book";
        public override double GetCost() => 10.00;
    }
}
