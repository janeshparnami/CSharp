using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePg295
{
    internal class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0, $"broken {color}")
        {
            Console.WriteLine("A bird laid a broken Egg.");
        }
    }
}
