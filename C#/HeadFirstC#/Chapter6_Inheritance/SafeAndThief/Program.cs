namespace SafeAndThief
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SafeOwner owner = new SafeOwner();
            Safe safe = new Safe();
            Locksmith lockSmith = new Locksmith();
            JewelThief jewelThief = new JewelThief();
            Locksmith jewelThiefAsLocksmith = new JewelThief();
            lockSmith.OpenSafe(safe, owner);
            jewelThief.OpenSafe(safe, owner);
            jewelThiefAsLocksmith.OpenSafe(safe, owner);
            Console.ReadKey(true);
        }
    }
}