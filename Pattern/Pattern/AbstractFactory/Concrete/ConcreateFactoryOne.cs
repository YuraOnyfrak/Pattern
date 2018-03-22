using Pattern.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactory.Concrete
{
    class ConcreateFactoryOne : AbstraktFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }
    }
}
