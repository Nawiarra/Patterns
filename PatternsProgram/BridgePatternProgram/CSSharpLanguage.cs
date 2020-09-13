using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternProgram
{
   public class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Using the Roslyn compiler, we compile the source code into an exe file");
        }

        public void Execute()
        {
            Console.WriteLine("JIT compiles a binary program");
            Console.WriteLine("CLR executes compiled binary");
        }
    }
}
