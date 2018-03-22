using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Abstract
{
   abstract class Element
    {
        public abstract void Accept(VisitorClass visitor);
    }
}
