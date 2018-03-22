using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Abstract;

namespace Visitor.Implement
{
    class Village
    {
        ArrayList array = new ArrayList();

        public void Add(Element element)
        {
            array.Add(element);
        }

        public void Accept(VisitorClass visitor)
        {
            foreach (Element item in array)
            {
                item.Accept(visitor);
            }
        }

    }
}
