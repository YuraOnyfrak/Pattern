using Builder.Abstract;
using Builder.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderHuman builder = new WoodBuilder();
            Director director = new Director(builder);

            director.Create();

            Home home = builder.GetHome();

             

            Console.ReadLine();
        }
    }
}
