using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly");
        }
    }
}
