﻿namespace CreateEnumeratorUsingYield
{
    internal class Program
    {
        static IEnumerable<string> SimpleEnumerable()
        {
            yield return "apples";
            yield return "oranges";
            yield return "bananas";
            yield return "unicorns";
        }
        static void Main(string[] args)
        {
            foreach (var s in SimpleEnumerable()) Console.WriteLine(s);
            BetterSportSequence sports = new BetterSportSequence();
            foreach (var sport in sports)
            {
                Console.WriteLine(sport);
            }
            Console.WriteLine(sports[3]);
        }
    }
}