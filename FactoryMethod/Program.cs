using FactoryMethod.Abstract;
using FactoryMethod.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Developer developer = new WoodDeveloper("wood");
            House house = developer.Create();

            developer = new PanelDeveloper("panel");
            House house1 = developer.Create();

            Console.ReadKey();
        }
    }
}
