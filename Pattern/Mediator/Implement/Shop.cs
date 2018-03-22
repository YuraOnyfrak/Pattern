using MediatorPattern.Abstract;
using System;

namespace MediatorPattern.Implement
{
     class Shop : Colleague
    {
        public Shop(Mediator mediator) : base(mediator)
        {

        }

        public void SellKetchup(string messege)
        {
            Console.WriteLine(this.GetType().Name + " sell " + messege);
        }
    }
}