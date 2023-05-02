using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_While
{
    internal class WhileBreakReturnDiff
    {
        //Break stops the while loop whereas return stops the function.
        //Neat trick.
        public void BreakVsReturn()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter an integer:");
                char c = Console.ReadKey(true).KeyChar;
                int value = (int)char.GetNumericValue(c);
                if (value == 9)
                    return;
                else if (value == 8)
                    break;
                else
                    sum += value;
                Console.WriteLine(sum);
            }
            Console.WriteLine("Exited While and not the Fucntion");
        }
    }
}
