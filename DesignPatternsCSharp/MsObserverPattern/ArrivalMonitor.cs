using System;
using System.Collections.Generic;
using System.Text;

namespace MsObserverPattern
{
    public class ArrivalMonitor : IObserver<BaggageInfo>
    {
        private string name;
        private  List<String> flightInfos = new List<string>();
        private IDisposable cancellation;
        private string fmt = "{0,-20} {1,5} {2, 3}";

        public ArrivalMonitor(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Invalid Observer Name");

            this.name = name;

        }


        public virtual void Subscribe(BaggageHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            flightInfos.Clear();
        }

        public virtual void OnCompleted()
        {
            flightInfos.Clear();
        }

        public virtual void OnError(Exception e)
        {
            //No Implementation
        }

        public void OnNext(BaggageInfo info)
        {
            bool updated = false;

            if (info.Carousel == 0)
            {
                var flightsToRemove = new List<String>();
                string flightNo = String.Format("{0,5}", info.FlightNumber);


                foreach (var flightInfo in flightInfos)
                {

                    if (flightInfo.Substring(21, 5).Equals(flightNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                    
                }

                foreach (var flighttoremove in flightsToRemove)
                {
                    flightInfos.Remove(flighttoremove);
                }

                flightsToRemove.Clear();
            }

            else
            {
                //Add flight if it doesn't exist
                string flightInfo = String.Format(fmt, info.From, info.FlightNumber, info.Carousel);
                if (!flightInfos.Contains(flightInfo))
                {
                    flightInfos.Add(flightInfo);
                    updated = true;
                }
            }

            if (updated)
            {
                flightInfos.Sort();
                Console.WriteLine("Arrivals information from {0}", this.name);
                foreach (var flightInfo in flightInfos)
                {
                    Console.WriteLine(flightInfo);
                }

                Console.WriteLine();
            }
        }

    }
}
