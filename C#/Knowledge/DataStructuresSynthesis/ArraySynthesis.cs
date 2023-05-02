using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresSynthesis
{
    public static class ArraySynthesis
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
        // --------------------------------------------------------- //

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int[] arr = new int[2];//Return Array
            int count = 0;
            int sum = 0;
            if(input != null && input.Length > 0)
            {
                foreach (int num in input) 
                {
                    if (num > 0) count++;
                    else if (num < 0) sum += num;
                }
                arr[0] = count;
                arr[1] = sum;
                return arr;
            }
            else return new int[0];
        }
        public static int[] CountPositivesSumNegatives_ProductionReady(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }

        // --------------------------------------------------------- //

        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            //Code here...
            return numbers[0] + numbers[1];
        }
        public static int SumTwoSmallestNumbers_Linq(int[] numbers) => numbers.OrderBy(n => n).Take(2).Sum();

        // --------------------------------------------------------- //

        public static long RowSumOddNumbers(long n)
        {
            int firstElemNthRow = 1;
            int increment = 2;
            long sum = 0;
            for (int i = 1; i < n; i++)
            {
                firstElemNthRow += increment;
                increment += 2;
            }
            for (int i = 0; i < n; i++)
            {
                sum += firstElemNthRow;
                firstElemNthRow += 2;
            }
            return sum;
        }

  /*
If you look down the middle of the triangle, you will see square numbers (you don't see them on even rows) like
1, 4, 9, 16, 25, 36...
  
             1                 <-- middle number is 1
          3     5              <-- middle number is 4
       7     9    11           <-- middle number is 9
   13    15     17    19       <-- middle number is 16
21    23    25     27    29    <-- middle number is 25

The middle number is also the average of the row numbers
 * The average of the second row is 4: (3+5)/2
 * The average of the third  row is 9: (7+9+11)/3

To work out the sum of a sequence we can multiply the average by the number of terms in the sequence

Notice that the second row has 2 terms, the third row has 3 terms, the Nth row has N terms
 
So to find a sum of a row we can multiply the average (the square of the row number) by the number of terms 
(also the row number)

This means that the answer is actually simply the cube (power 3) of the row number
  
  */
  
        public static long RowSumOddNumbers_Logic(long n) => n * n * n;

        // ------------------------------------------------------------- //

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> a1 =  a.ToList();
            for (int i = 0; i < b.Length; i++)
            {
                if (a1.Contains(b[i])) a1.RemoveAll(x => x.Equals(b[i]));
            }
            return a1.ToArray();
        }
        /// <summary>
        /// This is better as it uses Hash Set.contatins which is faster than List.contains.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] ArrayDiff_BetterPerformance(int[] a, int[] b)
        {
            HashSet<int> bSet = new HashSet<int>(b);

            return a.Where(v => !bSet.Contains(v)).ToArray();
        }
        // ########################################################### //

        public static int[] MoveZeroes(int[] arr)
        {
            IEnumerable<int> elem = arr.Where(x => x != 0);
            IEnumerable<int> zero = arr.Where((x) => x == 0);
            return elem.Concat(zero).ToArray();
        }

        public static int[] MoveZeroes_BetterPerformance(int[] arr)
        {
            // This solution makes use of C#'s behaviour with unassigned ints in arrays: They are 0 by default.
            // So we basically only have to create a new array with the same size, and write non-zero values
            // in their usual order. Simple.
            int[] zeroesAtEnd = new int[arr.Length];
            int currIndex = -1;
            foreach (int num in arr)
            {
                if (num != 0)
                {
                    currIndex++;
                    zeroesAtEnd[currIndex] = num;
                }
            }
            return zeroesAtEnd;
        }

        // ##################################################################### //



    }

}

