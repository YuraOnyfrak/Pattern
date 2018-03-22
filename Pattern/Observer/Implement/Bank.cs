using Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implement
{
    class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
     
        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.AddObservable(this);
        }

        public void Update(Object ob)
        {
            StockInfo stockInfo = (StockInfo)ob;
            if (stockInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
        }

        
    }
}
