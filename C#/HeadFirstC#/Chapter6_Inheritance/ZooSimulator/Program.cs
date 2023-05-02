namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new AnimalFeedVendingMachine();
            Console.Write(vendingMachine.Dispense(2.00M));
        }
    }
}