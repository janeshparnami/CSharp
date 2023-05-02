namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int value = random.Next();
            Console.WriteLine(value);
            int zeroToNine = random.Next(0, 10);
            Console.WriteLine(zeroToNine);
            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);
            Console.WriteLine((float)randomDouble * 100f);
            Console.WriteLine((decimal)randomDouble * 100m);
            int zeroToOne = random.Next(2);
            Console.WriteLine(zeroToOne);
            bool coinFlip = Convert.ToBoolean(zeroToOne);
            Console.WriteLine(coinFlip); // 0 - False, 1-infinity - True

        }

    }
}