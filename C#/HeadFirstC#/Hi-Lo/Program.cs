using System.Reflection;

namespace Hi_Lo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to HiLo.");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
            HiLoGame.Hint();
            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
                Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?') HiLoGame.Hint();
                else return;
            }
            Console.WriteLine("The pot is empty. Bye!");


            /*These are related to another COncept. Classes include HasASecret and SecretAgent*/
            //SecretAgent agent1 = new SecretAgent(1, "Janesh", "Parnami");
            //SecretAgent agent2 = new SecretAgent(2, "Vincent", "Mahto");


            //HasASecret keeper = new HasASecret();
            //// Uncommenting this Console.WriteLine statement causes a compiler error:
            //// 'HasASecret.secret' is inaccessible due to its protection level
            //// Console.WriteLine(keeper.secret);
            //FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (FieldInfo field in fields)
            //{
            //    Console.WriteLine(field.Name);
            //}
        }
    }
}