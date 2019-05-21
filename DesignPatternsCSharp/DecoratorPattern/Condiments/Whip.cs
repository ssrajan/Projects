using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}
