using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresSynthesis
{
    internal class StringToList
    {
        /// <summary>
        /// Converts a string to a list of char.
        /// </summary>
        public void CharList()
        {
            string str = "ABCDE";

            List<char> chars = new List<char>();
            chars.AddRange(str);

            Console.WriteLine(String.Join(", ", chars));        // A, B, C, D, E
            
        }

        /// <summary>
        /// Converts a string to a list of strings.
        /// </summary>
        public void StringList()
        {
            string str = "ABCDE";

            List<string> chars = new List<string>();
            chars.AddRange(str.Select(c => c.ToString()));

            Console.WriteLine(String.Join(", ", chars));        // A, B, C, D, E
            
        }

        /// <summary>
        /// Converts a string to a list using a list constructor
        /// </summary>
        public void CharListUsingListConstructor()
        {
            string str = "ABCDE";

            List<char> chars = new List<char>(str);

            Console.WriteLine(String.Join(", ", chars));
        }
        /// <summary>
        /// Converts a string to a string list using a list constructor.    
        /// </summary>
        public void StringListUsingListConstructor()
        {
            string str = "ABCDE";

            List<string> chars = new List<string>(str.Select(c => c.ToString()));

            Console.WriteLine(String.Join(", ", chars));

        }

        /// <summary>
        /// Converts a string to a char list using an Enumerable.ToList Method
        /// </summary>
        public void EnumerableToList()
        {
            string str = "ABCDE";

            List<char> chars = str.ToList();

            Console.WriteLine(String.Join(", ", chars));        // A, B, C, D, E
        }


    }
}
