namespace CollectionsEnumsShoeCloset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShoeCloset shoeCloset = new ShoeCloset();
            //while (true)
            //{
            //    shoeCloset.PrintCloset();
            //    Console.Write("\nPress 'a' to add or 'r' to remove a shoe: ");
            //    char key = Console.ReadKey().KeyChar;
            //    switch (key)
            //    {
            //        case 'a':
            //        case 'A':
            //            shoeCloset.AddShoe();
            //            break;
            //        case 'r':
            //        case 'R':
            //            shoeCloset.RemoveShoe();
            //            break;
            //        default:
            //            return;
            //    }
            //}

            List<Shoe> shoes = new List<Shoe>()
            {
                new Shoe() {typeShoe = TypeShoe.Sneakers, Size = 12, Color = "black" },
                new Shoe() {typeShoe = TypeShoe.FlipFlop, Size = 14, Color = "red"},
                new Shoe() {typeShoe = TypeShoe.Mountain, Size = 10, Color = "green"},
                new Shoe() {typeShoe = TypeShoe.Boots, Size = 15, Color = "brown"},
                new Shoe() {typeShoe = TypeShoe.Party, Size = 11, Color = "dark brown"},
            };
            foreach (Shoe sho in shoes)
                Console.WriteLine(sho.Description);
            shoes.Sort();
            Console.WriteLine("\n");
            foreach (Shoe sho in shoes)
            {
                Console.WriteLine(sho.Description);
            }
        }
    }
}