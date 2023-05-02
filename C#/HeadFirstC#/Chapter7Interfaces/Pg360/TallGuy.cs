using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pg360
{
    internal class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave => "big red shoes";
        
        public void Honk() => Console.WriteLine("Honk honk!");

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
