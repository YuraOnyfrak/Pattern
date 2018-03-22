using Bridge_Structure_patern_.Abstraction;
using Bridge_Structure_patern_.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structure_patern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer _freelancer = new FreelanceProgramer(new CSharpLanguage());
            _freelancer.DoWork();
            _freelancer.EarnMoney();
            _freelancer.Language = new CLanguage();

            _freelancer.DoWork();
            _freelancer.EarnMoney();
            Console.Read();
        }
    }
}
