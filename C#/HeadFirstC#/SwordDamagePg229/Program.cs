namespace SwordDamagePg229
{
    internal class Program
    {
        /*Encapuslated  Sword Damage */
        public static Random random = new Random();
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
            
            SwordDamageEncapsulated swordDamageEncapsulated = new SwordDamageEncapsulated(RollDice());
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                swordDamageEncapsulated.Roll = RollDice();
                swordDamageEncapsulated.Magic = (key == '1' || key == '3');
                swordDamageEncapsulated.Flaming = (key == '2' || key == '3');
                Console.WriteLine("\nRolled " + RollDice() + " for " + swordDamageEncapsulated.Damage + " HP\n");
            }
        }
        /*Encapuslated  Sword Damage */
        public static int RollDice()
        {
            int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            return roll;
        }
    }
}