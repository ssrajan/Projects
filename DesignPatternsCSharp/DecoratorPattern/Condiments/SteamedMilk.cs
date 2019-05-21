using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        private Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", S Milk";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}
