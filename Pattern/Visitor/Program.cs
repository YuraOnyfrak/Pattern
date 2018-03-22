using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Implement;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Village village = new Village();
            village.Add(new BoyHouse());
            village.Add(new GirlHouse());

            village.Accept(new Santa());

            Console.Read();
        }
    }
}
