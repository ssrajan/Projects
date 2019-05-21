using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
