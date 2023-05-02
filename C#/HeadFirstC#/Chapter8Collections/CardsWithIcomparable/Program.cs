namespace CardsWithIcomparable
{
    internal class Program
    {
        public static readonly Random random= new Random();
        
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Console.Write("Enter number of Cards: ");
            if(int.TryParse(Console.ReadLine(), out int numCards))
            {
                for (int i = 0; i < numCards; i++)
                {
                    cards.Add(RandomCard());
                }
                PrintCards(cards);
            }
            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n... sorting the cards ...\n");
            PrintCards(cards);
        }
        public static Card RandomCard()
        {
            Values value = (Values)random.Next(1, 14);
            Suits suit = (Suits)random.Next(4);
            return new Card(value, suit);
        }

        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards) 
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}