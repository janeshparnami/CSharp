using SwordDamagePg229;
using System;

namespace ArrowDamagePg274
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            /*UnEncapuslated Sword Damage Class*/

            //Random random = new Random();
            //SwordDamage swordDamage = new SwordDamage();
            //while (true)
            //{
            //    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
            //    "3 for both, anything else to quit: ");
            //    char key = Console.ReadKey().KeyChar;
            //    if (key != '0' && key != '1' && key != '2' && key != '3') return;
            //    int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            //    swordDamage.Roll = roll;
            //    swordDamage.SetMagic(key == '1' || key == '3');
            //    swordDamage.SetFlaming(key == '2' || key == '3');
            //    Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP\n");
            //}

            /*Encapuslated  Sword Damage class*/

            SwordDamageEncapsulated swordDamageEncapsulated = new SwordDamageEncapsulated(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
            while (true)
            {

                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " + "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        swordDamageEncapsulated.Roll = RollDice(3);
                        swordDamageEncapsulated.Magic = (key == '1' || key == '3');
                        swordDamageEncapsulated.Flaming = (key == '2' || key == '3');
                        Console.WriteLine("\nRolled " + RollDice(3) + " for " + swordDamageEncapsulated.Damage + " HP\n");

                        break;
                    case 'A':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = (key == '1' || key == '3');
                        arrowDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine("\nRolled " + RollDice(1) + " for " + arrowDamage.Damage + " HP\n");

                        break;
                    default: return;

                }
            }
        }
        /*Encapuslated  Sword Damage */
        public static int RollDice(int numberOfRolls)
        {
            int roll = 0;
            for (int i = 0; i < numberOfRolls; i++) roll += random.Next(1, 7);
            return roll;
        }
    }
}