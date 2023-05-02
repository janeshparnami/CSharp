using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresSynthesis
{
    public static class StringUnderstanding
    {
        public static string CountSheep(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++) 
            {
                sb.Append(i).Append(" sheep...");
            }
            return sb.ToString();
        }
        public static string CountSheep_BestPractices(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += $"{i} sheep...";
            }
            return result;
        }
        public static string CountSheep_Linq(int n)
        {
            return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
        }

    }
}
