using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Abstract;

namespace Visitor.Implement
{
    class GirlHouse : Element
    {
        public override void Accept(VisitorClass visitor)
        {
            visitor.VisitGirlHouse(this);
        }


        public void GiveDress()
        {
            Console.WriteLine("GiveDress");
        }
    }
}
