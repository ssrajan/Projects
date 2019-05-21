using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
           flyBehaviour = new FlyWithWings();
           quackBehaviour = new QuackDuck();
        }

        public override void display()
        {
            Console.WriteLine(" I am a Mallard Duck");
        }
    }
}
