using MediatorPattern.Abstract;
using MediatorPattern.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            Farmer farmer = new Farmer(mediator);
            Cannery cannery = new Cannery(mediator);
            Shop shop = new Shop(mediator);
          

            mediator.Farmer = farmer;
            mediator.Cannery = cannery;
            mediator.Shop = shop;

            farmer.GrowTomato();

            Console.Read();

        }
    }
}
