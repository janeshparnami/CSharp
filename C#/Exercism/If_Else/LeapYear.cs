using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            else if(year % 100 == 0) return false;
            else if(year % 4== 0) return true;
            else
                return false;
        }
        //Chain of boolean expressions
        public static bool IsLeapYear1(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            
        }
        public static bool IsLeapYear2(int year)
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
        public static bool IsLeapYear3(int year)
        {

        }
        public static bool IsLeapYear4(int year)
        {

        }
    }
}
