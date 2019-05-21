using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();
            mallard.display();


            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehaviour(new FlyRocketPowered());
            model.performFly();

            Console.ReadKey();
        }
    }
}
