using System;
using System.Collections.Generic;
using Builder.Abstract;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implement
{
    class WoodBuilder : BuilderHuman
    {
        Home home = new Home();

        public override void CreateFirstFlour()
        {
            home.Add("FirstFlour");
        }

        public override void CreateRoof()
        {
            home.Add("Roof");
        }

        public override void CreateSecondFlour()
        {
            home.Add("SecondFlour");
        }

        public override Home GetHome()
        {
            return home;
        }
    }
}
