using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interface;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float t;
        private float h;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions : " + t + " C Degrees and " + h + " % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.t = temp;
            this.h = humidity;
            Display();
        }
    }
}
