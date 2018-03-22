using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Abstract
{
    interface IObservable
    {
       void AddObservable(IObserver obserer);
       void RemoveObservable(IObserver obserer);
       void NotifyObservers();
    }
}
