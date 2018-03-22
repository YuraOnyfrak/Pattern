using MediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Implement
{
    class Farmer : Colleague
    {
        public Farmer(Abstract.Mediator mediator) : base(mediator)
        {
        }

        public void GrowTomato()
        {
            string tomato = "Tomato";

            Console.WriteLine(this.GetType().Name + " raised "  + tomato);

            Mediator.Send(tomato,this);
        }
    }
}
