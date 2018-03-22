using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("Windows 10");
            Console.WriteLine(computer.OS.NameOS);


            Console.ReadLine();
        }
    }
}
