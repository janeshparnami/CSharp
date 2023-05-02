using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay1_2
{
    /* Average Salary Excluding the Minimum and Maximum Salary
     * Constraints:

            3 <= salary.length <= 100
            1000 <= salary[i] <= 106
            All the integers of salary are unique.
     * 
     */

    internal class SalaryCalculation
    {
        public static float AverageSalary(int[] salary)
        {
            int _max = int.MinValue, _min = int.MaxValue;
            float _sum = 0;
            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] > _max) _max = salary[i];
                if (salary[i] < _min) _min = salary[i];
                _sum += salary[i];

            }
            _sum -= _max + _min;
            float avg = _sum / (salary.Length - 2);
            return avg;
        }

    }
}
