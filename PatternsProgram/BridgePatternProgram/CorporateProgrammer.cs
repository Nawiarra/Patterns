using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternProgram
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang)
            : base(lang)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("We receive a salary at the end of the month");
        }
    }
}
