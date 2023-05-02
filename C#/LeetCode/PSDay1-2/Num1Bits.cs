using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay1_2
{
    internal class Num1Bits
    {
        public static int HammingWeight(uint n)
        {
            /*Best Way
             */
            //return System.Numerics.BitOperations.PopCount(n);


            /*2nd Way
             */
            //int count = Convert.ToString(n, 2).Count(x => x == '1');
            //return count;


            /*Natural Way, also teaches the concept
             * Take Modulo and if remainder is 1 that means it is a 1 Bit.
             */
            uint count = 0; 
            while(n != 0) 
            {
                count += n % 2;
                n /= 2;
            }
            return (int)count;
        }
    }
}
