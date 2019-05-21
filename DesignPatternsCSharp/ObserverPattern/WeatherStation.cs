using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            
            weatherData.setMeasurements(80,65,34.5f);
            weatherData.setMeasurements(45, 78, 32.5f);
            weatherData.setMeasurements(78, 90, 37.5f);
            Console.ReadKey();
        }
        
    }

}
