using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoReferences4
{
    internal class Elephant
    {
        public string _name;
        public int _earSize;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {_name}.");
            Console.WriteLine($"My ears are {_earSize} inches tall");
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(_name+ " heard a message");
            Console.WriteLine(whoSaidIt._name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
