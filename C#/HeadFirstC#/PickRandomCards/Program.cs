namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] randomCards =  CardPicker.PickSomeCards(7);
            foreach(string card in randomCards)
            {
                Console.WriteLine(card);
            }

        }
    }
}