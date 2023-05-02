using System.Linq;
namespace LinqTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThirdTest();
            ModifiedThirdTest();
        }

        private static void FirstTest()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 99; i++)
            {
                numbers.Add(i);
            }
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));
            foreach (int i in firstAndLastFive)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine($"Last : {numbers.Last()}, Min: {numbers.Min()},");
        }

        private static void SecondTest() 
        {
            var array = new[] { 1, 2, 3, 4 };
            var result = array.Select(i => i * 2);
            //int[] arr = result.ToArray(); //converting to array
            foreach (var i in result) Console.WriteLine(i);
        }
        private static void ThirdTest()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result =
            from v in values
            where v < 37
            orderby -v 
            select v;
            foreach (var i in result) Console.WriteLine(i);

        }
        private static void ModifiedThirdTest()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result = values.Where(l => l < 37).OrderBy(l => -l);
            foreach (var i in result) Console.WriteLine(i);

        }
    }
}