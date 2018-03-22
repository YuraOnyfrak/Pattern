using Pattern.AbstractFactory.Abstract;
using Pattern.AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstraktFactory factory1 = new ConcreateFactoryOne();
            Clients clients1 = new Clients(factory1);
            clients1.Run();

            AbstraktFactory factory2 = new ConcreateFactoryOne();
            Clients clients2 = new Clients(factory1);
            clients2.Run();

            Console.ReadKey();
        }
    }
}
