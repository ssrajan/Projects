using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
