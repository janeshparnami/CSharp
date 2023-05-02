using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDay1
{
    internal class MaximumSubarray
    {
        private int _maxSoFar = int.MinValue, _maxEndingHere = 0, start = 0, end = 0, s =0;

        //Kadane's Algorithm
        public int MaxSumSubarray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                _maxEndingHere += nums[i];

                if(_maxSoFar < _maxEndingHere)
                {
                    _maxSoFar = _maxEndingHere;
                    start = s;
                    end = i;
                }
                
                if(_maxEndingHere < 0)
                {
                    _maxEndingHere = 0;
                    s = i + 1;
                }
            }
            Console.WriteLine(start + " " + end);
            return _maxSoFar;
        }
    }
}
