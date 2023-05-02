using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay3_4
{
    internal class LargestPerimeterTriangle
    {
        public static int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            /*Another way of writing the for loop
             i = length - 3; i >=0; --i
            */
            for (int i = 0; i <= nums.Length - 3; i++)
            {
                int largest = nums[i];
                int middle = nums[i + 1];
                int smallest = nums[i + 2];
                if (nums[i+1] + nums[i+2] > nums[i])
                {
                    return largest + middle + smallest;
                }
            }
            return 0;
        }
    }
}
