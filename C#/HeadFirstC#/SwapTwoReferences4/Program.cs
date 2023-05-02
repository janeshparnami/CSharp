using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SwapTwoReferences4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() { _name = "Lloyd", _earSize = 40 };
            Elephant lucinda = new Elephant() { _name = "Lucinda", _earSize = 33 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while(true)
            {
                /*Read a character input from console and convert into an int 3 working 1 not-working*/

                
                
                char input = Console.ReadKey(true).KeyChar;
                int value = Convert.ToInt32(input.ToString());
                Debug.WriteLine(value);
                Debug.WriteLine("Debug does work");//TODO: Fix why debug is not working.

                //string? line = Console.ReadLine();
                //int.TryParse(line, out int value);
                //int value = (int)char.GetNumericValue(input);
                //int value = input - '0'; // This works because each character has a numerical value and they are consecutive.

                //int value = Convert.ToInt32(input); // This does not work because the argument it requires should be a string.
                Console.WriteLine($"You pressed {value}");
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();
                        break;
                    case 2:
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI(); 
                        break;
                    case 3:
                        Console.WriteLine("References have been swapped.");
                        Elephant tea = lloyd;
                        lloyd = lucinda;
                        lucinda = tea;
                        break;
                    case 4:
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                        break;
                    default:
                        return; 

                }
            }

        }
    }
}