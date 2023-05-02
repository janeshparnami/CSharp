using BenchmarkDotNet.Running;
namespace YieldReturn
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProcessPeople();
            //ProcessPeopleYield();
            var summary = BenchmarkRunner.Run<YieldBenchmarks>();
        }
        public static void ProcessPeople()
        {
            var people = GetPeople(1_000_000);
            foreach (var person in people)
            {
                if (person.Id < 1000)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
                }
                else
                    break;
            }
        }



        private static List<Person> GetPeople(int count)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                people.Add(new Person() { Id = i, Name = $"Name {i}" });
            }
            return people;
        }

        /*GetPeople IEnumerable version works the same way as the generic verison */
        //private static IEnumerable<Person> GetPeople(int count)
        //{
        //    List<Person> people = new List<Person>();
        //    for (int i = 0; i < count; i++)
        //    {
        //        people.Add(new Person() { Id = i, Name = $"Name {i}" });
        //    }
        //    return people;
        //}

        public static void ProcessPeopleYield()
        {
            var people = GetPeopleYield(1_000_000);
            foreach (var person in people)
            {
                if (person.Id < 1000)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
                }
                else
                    break;
            }
        }

        /*This works differently then the previous version of the IEnumerable without the yield return
         Add breakpoints and debug this again*/
        private static IEnumerable<Person> GetPeopleYield(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Person() { Id = i, Name = $"Name {i}" };
            }
        }
    }
}