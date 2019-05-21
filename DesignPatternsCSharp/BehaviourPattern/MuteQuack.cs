using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public  class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
