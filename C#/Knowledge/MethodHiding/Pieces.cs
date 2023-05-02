using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public abstract class Pieces
    {
        public string Name { get; set; } 
        protected void DoSomething(string name, int number)
        {
            Name = name;
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Numbet: {number}");
        }
    }
}
