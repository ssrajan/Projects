using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
