using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay3_4
{
    internal class SignumFunction
    {
        public static int ArraySign(int[] nums)
        {
            int negativeCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) return 0;
                if (nums[i] < 0) negativeCount++;
            }
            return negativeCount % 2 == 0 ? -1 : 1;
        }

    }
}
