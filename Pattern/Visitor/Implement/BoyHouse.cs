using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Abstract;

namespace Visitor.Implement
{
    class BoyHouse : Element
    {
        public override void Accept(VisitorClass visitor)
        {
            visitor.VisitBoyHouse(this);
        }

        public void TellFairlyTale()
        {
            Console.WriteLine("FairlyTale");
        }
    }
}
