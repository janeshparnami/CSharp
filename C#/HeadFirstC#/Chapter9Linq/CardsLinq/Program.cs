namespace CardsLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var deck = new Deck()
            //    .Shuffle()
            //    .Take(16);
            //IOrderedEnumerable<IGrouping<Suits, Card>> grouped = GroupBySuit(deck);
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine(@$"Group: {group.Key}
            //    Count: {group.Count()}
            //    Minimum: {group.Min()}
            //    Maximum: {group.Max()}");
            //}

            var deck = new Deck();
            var processedCards = deck
            .Take(3)
            .Concat(deck.TakeLast(3))
            .OrderByDescending(card => card)
            .Select(card => card.Value switch
            {
                Values.King => Output(card.Suit, 7),
                Values.Ace => $"It's an ace! {card.Suit}",
                Values.Jack => Output((Suits)card.Suit - 1, 9),
                Values.Two => Output(card.Suit, 18),
                _ => card.ToString(),
            });
            foreach (var output in processedCards)
            {
                Console.WriteLine(output);
            }
        }

        private static IOrderedEnumerable<IGrouping<Suits, Card>> GroupBySuit(IEnumerable<Card> deck)
        {
            return from card in deck
                   group card by card.Suit into suitGroup
                   orderby suitGroup.Key descending
                   select suitGroup;
        }

        //Pg 518 Sharpen your pencil
        static string Output(Suits suit, int number) => $"Suit is {suit} and number is {number}";
    }
}