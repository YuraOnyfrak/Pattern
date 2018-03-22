using MediatorPattern.Abstract;
using System;

namespace MediatorPattern.Implement
{
     class Cannery: Colleague
     {
        public Cannery(Mediator mediator) : base(mediator)
        {
        }

        public  void MakeKetchup(string messege)
        {
            string ketchup = messege+ " Ketchup";

            Console.WriteLine(this.GetType().Name + " produced " + ketchup);

            Mediator.Send(ketchup, this);
        }
     }
}