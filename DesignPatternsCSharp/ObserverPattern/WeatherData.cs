using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ObserverPattern.Interface;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList _observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }
        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            var i = _observers.IndexOf(o);

            if (i>=0) _observers.RemoveAt(i);
        }

        public void notifyObservers()
        {
            foreach (var o in _observers)
            {
                IObserver item = (IObserver) o;
                item.Update(temperature, humidity, pressure);
            }
        
        }

        public void measurementsChanged()
        {
            notifyObservers();
            
        }

        public void setMeasurements(float temp, float h, float p)
        {
            this.temperature = temp;
            this.humidity = h;
            this.pressure = p;
            measurementsChanged();
        }

    }
}
