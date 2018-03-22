using Prototype.Abstract;
using Prototype.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(12, 12);
            IFigure figureClone = figure.Clone();
            figure.GetInfo();
            figureClone.GetInfo();


            figure = new Circle(30);
            figureClone = figure.Clone();
            figure.GetInfo();
            figureClone.GetInfo();

            Console.ReadLine();
        }
    }
}
