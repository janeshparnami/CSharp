using Pg_449_Lumberjack;

Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
while (true)
{
    string name;
    Console.Write("Next lumberjack's name (blank to end): ");
    if ((name = Console.ReadLine()) != "")
    {
        Lumberjack lumberjack = new Lumberjack(name);
        Console.Write("Number of flapjacks: ");
        if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int numFj))
        {
            for (int i = 0; i < numFj; i++)
            {
                lumberjack.TakeFlapjack((Flapjack)new Random().Next(4));
            }
        }
        lumberjacks.Enqueue(lumberjack);
    }
    else
    {
        while (lumberjacks.Count != 0)
        {
            lumberjacks.TryDequeue(out Lumberjack lj);
            Console.WriteLine($"{lj.Name} is eating flapjacks");
            lj.EatFlapjack();
        }
        return;
    }
}
