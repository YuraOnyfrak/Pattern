using Pattern.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Clients
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Clients(AbstraktFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
}
