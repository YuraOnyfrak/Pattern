using AbstractFactory.Abstract;
using AbstractFactory.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroFactory voin = new VoinFactory();
            voin = new ElfFactory();
            Hero heroVoin = new Hero(voin);
            heroVoin.Hit();
            heroVoin.Run();


            Console.ReadLine();
        }
    }
}
