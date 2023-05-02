using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;



namespace YieldReturn
{
    /*This whole class is for benchmarking only*/
    [MemoryDiagnoser]
    public class YieldBenchmarks
    {
        [Benchmark]
        public  void ProcessPeople()
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

        private  List<Person> GetPeople(int count)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                people.Add(new Person() { Id = i, Name = $"Name {i}" });
            }
            return people;
        }

        [Benchmark]
        public  void ProcessPeopleYield()
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
        private  IEnumerable<Person> GetPeopleYield(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Person() { Id = i, Name = $"Name {i}" };
            }
        }
    }
}
