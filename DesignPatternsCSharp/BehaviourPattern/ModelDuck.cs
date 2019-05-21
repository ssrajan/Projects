using System;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new QuackDuck();
        }

        public override void display()
        {
            Console.WriteLine("I am model duck");
        }
    }
}
