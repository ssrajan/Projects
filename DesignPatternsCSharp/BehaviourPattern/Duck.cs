using System;
using StrategyPattern.Interface;

namespace StrategyPattern
{
    public abstract class Duck
    {
         protected IFlyBehaviour flyBehaviour;
         protected IQuackBehaviour quackBehaviour;

        public Duck()
        {
            
        }

        public abstract void display();

        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void performQuack()
        {
            quackBehaviour.Quack();
        }

        public void setQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }

        public void setFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void swim()
        {
            Console.WriteLine("All ducks can swim");
        }
    }
}
