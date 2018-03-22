using Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implement
{
    class Stock : IObservable
    {
        List<IObserver> _listObserverers;
        StockInfo sInfo;

        public Stock()
        {
            _listObserverers = new List<IObserver>();
            sInfo = new StockInfo();
        }

        public void AddObservable(IObserver obserer)
        {
            _listObserverers.Add(obserer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver item in _listObserverers)
            {
                item.Update(sInfo);
            }
        }

        public void RemoveObservable(IObserver obserer)
        {
            _listObserverers.Remove(obserer);
        }

        public void Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(20, 40);
            sInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}
