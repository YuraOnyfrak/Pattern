using Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implement
{
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {            
            Console.WriteLine("Круг радиусом {0}", radius);
        }
    }
}
