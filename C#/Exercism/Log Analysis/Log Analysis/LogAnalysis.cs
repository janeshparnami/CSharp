using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Log_Analysis
{
    /// <summary>
    /// Extension Methods
    /// Note the "static" and also the "this" in parmaters.
    /// Also go to Main and see how they are called
    /// </summary>
    public static class LogAnalysis
    {
        /// <summary>
        /// This is an Extension method that extends the string class.Note the Static keyword.
        /// </summary>
        /// <param name="str">'this' keyword behind the parameter is what makes it an extension method and the type string defines what type is being extended</param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string SubstringAfter(this string str, string delimiter)
        {
            return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
        }

        public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
        {
            int indexDelimiter1 = str.IndexOf(delimiter1);
            int indexDelimiter2 = str.IndexOf(delimiter2);
            return str.Substring(indexDelimiter1 + delimiter1.Length, indexDelimiter2 - (indexDelimiter1 + delimiter1.Length));
        }

        public static string Message(this string str)
        {
            return str.SubstringAfter(":").Trim();
        }

        public static string LogLevel(this string str)
        {
            return str.SubstringBetween("[", "]");
        }
    }
}
