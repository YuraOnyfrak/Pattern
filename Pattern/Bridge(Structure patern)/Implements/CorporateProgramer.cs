using Bridge_Structure_patern_.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structure_patern_.Implements
{
    class CorporateProgramer : Programmer
    {
        public CorporateProgramer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");

        }
    }
}
