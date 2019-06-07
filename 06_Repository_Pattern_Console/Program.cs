using _06_Repository_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI(new StreamingContentRepository());
            program.Run();
        }
    }
}
