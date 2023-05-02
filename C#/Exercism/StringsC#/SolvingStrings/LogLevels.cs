using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingStrings
{
    internal class LogLevels
    {
        public static string Message(string logLine)
        {
            string message;
            string subStringInstance = ": ";
            int ind = logLine.IndexOf(subStringInstance); // This is the start index
            message = logLine.Substring(ind+2).Trim();
            return message;
        }

        public static string LogLevel(string logLine)
        {
            string startInstance = "[";
            string endInstance = "]";
            int start = logLine.IndexOf(startInstance);
            int end = logLine.IndexOf(endInstance);
            string message = logLine.Substring(start+1, end - start - 1);
            return message.ToLower();
        }

        public static string Reformat(string logLine)
        {
            return LogLevels.Message(logLine) + " " + "(" + LogLevels.LogLevel(logLine) + ")";
        }
    }
}
