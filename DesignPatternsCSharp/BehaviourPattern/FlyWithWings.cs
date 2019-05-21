using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public class FlyWithWings:IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying");
        }
    }
}
