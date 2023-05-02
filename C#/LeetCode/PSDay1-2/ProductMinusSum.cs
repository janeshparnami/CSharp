using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay1_2
{
    internal class ProductMinusSum
    {
        public static int SubtractProductAndSum(int num)
        {
            int prod = 1, sum = 0;//Note: prod initialized to 1 and sum to 0
            while(num != 0) 
            {
                prod *= num % 10;
                sum += num % 10;
                num /= 10;
            }
            return prod - sum;
        }
    }
}
