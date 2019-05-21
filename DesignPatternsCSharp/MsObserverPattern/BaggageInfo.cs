using System;
using System.Collections.Generic;
using System.Text;

namespace MsObserverPattern
{
    public class BaggageInfo
    {
        public int FlightNumber { get; set; }
        public string  From { get; set; }
        public int Carousel { get; set; }

        internal  BaggageInfo(int flight, string from , int carousel)
        {
            FlightNumber = flight;
            From = from;
            Carousel= carousel;
        }
    }
}
