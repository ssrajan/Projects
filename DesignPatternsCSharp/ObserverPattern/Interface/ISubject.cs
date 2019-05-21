using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interface
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }
}
