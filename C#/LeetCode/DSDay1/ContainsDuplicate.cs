using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDay1
{
    internal class ContainsDuplicate
    {
        //Naieve way of doing this O(n^2)
        //public static bool HasDuplicate(int[] nums)
        //{
        //    int count;
        //    foreach (var element in nums)
        //    {
        //        count = 0;
        //        foreach (var num in nums)
        //        {
        //            if (num == element) count++;
        //        }
        //        if (count > 1) return true;
        //    }
        //    return false;
        //}

        //This meethod uses HashSet which is quite fast.
        //public static bool HasDuplicate(int[] nums)
        //{
        //    HashSet<int> set = new HashSet<int>(nums);

        //    if(set.Count < nums.Length)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static bool HasDuplicate(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }
            return false;
        }
    }
}
