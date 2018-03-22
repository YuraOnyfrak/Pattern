using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structure_patern_.Abstraction
{
   abstract class Programmer
    {
        protected ILanguage _language;

        public ILanguage Language
        {
            set { _language = value; }
        }

        public Programmer(ILanguage language)
        {
            _language = language;
        }

        public virtual void DoWork()
        {
            _language.Build();
            _language.Execute();
        }

        public abstract void EarnMoney();
    }
}
