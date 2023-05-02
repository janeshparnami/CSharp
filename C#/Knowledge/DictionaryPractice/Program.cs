using System.Collections.Generic;
namespace DictionaryPractice
{
    internal class Program
    {
        public static Dictionary<string, int[]> tangram = new();
        static void Main(string[] args)
        {
            tangram["Ship"] = new int[] { 5, 3, 2 };
            tangram["Swan"] = new int[] { 6, 2, 2 };
            tangram["Dog"] = new int[] { 7, 2, 1 };
            tangram["House"] = new int[] { 5, 4, 1 };
            tangram["Shark"] = new int[] { 7, 2, 1 };
            for (int x = 0; x < tangram.Count; x++)
            {
                Console.WriteLine("{0} and {1}", tangram.Keys.ElementAt(x), string.Join(",", tangram[tangram.Keys.ElementAt(x)]));
            }

        }
    }
}