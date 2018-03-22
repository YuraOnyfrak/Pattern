using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Implement;

namespace Visitor.Abstract
{
   abstract class VisitorClass
    {
        public abstract void VisitBoyHouse(BoyHouse boyHouse);
        public abstract void VisitGirlHouse(GirlHouse girlHouse);
    }
}
