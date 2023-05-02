using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay3_4
{
    internal class CanMakeArithmeticProgression
    {
        public static bool IsAP(int[] arr)
        {
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] != diff)
                    return false;
            }
            return true;
        }
    }
}
