using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public class QuackDuck : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
