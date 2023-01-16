using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Hello world");
#if DEBUG
            Console.WriteLine("Debug version");
#endif

            if (i == 1)
                Console.WriteLine("Hello world");
        }
    }
}
