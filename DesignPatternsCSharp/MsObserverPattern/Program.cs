using System;

namespace MsObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BaggageHandler provider = new BaggageHandler();
            ArrivalMonitor observer1 = new ArrivalMonitor("BaggageClaimsMonitor1");
            ArrivalMonitor observer2 = new ArrivalMonitor("SecurityExit");

            provider.BaggageStatus(712, "Detroit", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            provider.BaggageStatus(712);
            observer2.Unsubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();

            Console.ReadKey();
        }
    }
}
