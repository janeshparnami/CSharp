using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay3_4
{
    internal class NumberIsHappy
    {
        //202 Happy Number
        public static bool IsHappy(int n)
        {
            int num = n;
            Dictionary<int, int> numEncountered= new Dictionary<int, int>();
            while (true)
            {
                List<int> list = new List<int>();
                while (n != 0)
                {
                    list.Add(n % 10);
                    n /= 10;
                }
                int sum = 0;
                foreach (int item in list)
                {
                    sum += (int)Math.Pow(item,2);
                }
                if (sum == 1) return true;
                if (numEncountered.ContainsKey(sum)) return false;
                numEncountered.Add(num, sum);
                n = sum;
            }
        }
        //Can be done with Hash Set also.See if you can achieve that.
        //public static bool IsHappy1(int n)
        //{

        //}
    }
}
