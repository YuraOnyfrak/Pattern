using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implement
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Run();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
