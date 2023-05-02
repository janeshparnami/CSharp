using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Queen : Pieces
    {
        private const int number = 9;
        private const string name = "Queen";
        public Queen() { }
        public void DoSomething(string message)
        {
            Console.WriteLine(message);
            DoSomething(name, number);
        }
    }
}
