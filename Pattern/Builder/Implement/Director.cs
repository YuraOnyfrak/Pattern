using Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implement
{
    class Director
    {
        BuilderHuman _builder;

        public Director(BuilderHuman builder)
        {
            _builder = builder;
        }

        public void Create()
        {
            _builder.CreateFirstFlour();
            _builder.CreateSecondFlour();
            _builder.CreateRoof();
        }
    }
}
