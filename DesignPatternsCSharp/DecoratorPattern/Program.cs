using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.getDescription() + " £"  + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Whip(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
           Console.WriteLine(beverage2.getDescription() + " £" + beverage2.cost()); 

           Beverage beverage3 = new Mocha(new Mocha(new DarkRoast()));
           Console.WriteLine(beverage3.getDescription() + " £" + beverage3.cost());


            Console.ReadKey();
            
        }
    }
}
