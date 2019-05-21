using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {

        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double cost()
        {
            return 0.99;
        }
    }
}
