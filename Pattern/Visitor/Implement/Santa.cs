using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Abstract;

namespace Visitor.Implement
{
    class Santa : VisitorClass
    {
        public override void VisitBoyHouse(BoyHouse boyHouse)
        {
            boyHouse.TellFairlyTale();
        }

        public override void VisitGirlHouse(GirlHouse girlHouse)
        {
            girlHouse.GiveDress();
        }
    }
}
