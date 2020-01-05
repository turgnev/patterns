using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservable
    {
        void AddObserver(IObserver o);

        void DeleteObserver(IObserver o);

        void InformObservers();
    }
}
