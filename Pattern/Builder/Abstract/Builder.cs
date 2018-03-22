using Builder.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Abstract
{
    abstract class BuilderHuman
    {
        public abstract void CreateFirstFlour();

        public abstract void CreateSecondFlour();

        public abstract void CreateRoof();

        public abstract Home GetHome();
    }
}
