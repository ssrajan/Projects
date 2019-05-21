using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with RocketPower");
        }
    }
}
