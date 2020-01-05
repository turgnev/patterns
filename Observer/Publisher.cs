using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Publisher : IObservable
    {
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void DeleteObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void InformObservers()
        {
            foreach (var o in observers)
                o.Update();
        }

        private List<IObserver> observers;

        public Publisher()
        {
            observers = new List<IObserver>();
        }
    }
}
