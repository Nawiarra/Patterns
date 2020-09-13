using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternProgram
{
    public class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Using the C++ compiler, we compile the program into binary code");
        }

        public void Execute()
        {
            Console.WriteLine("Run the executable file of the program");
        }
    }
}
