using System;
using System.Collections.Generic;
using System.Text;

namespace MsObserverPattern
{
    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private List<IObserver<BaggageInfo>> _observers;
        private IObserver<BaggageInfo> _observer;

        internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
