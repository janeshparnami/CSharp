namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rook rook = new Rook();
            //rook.Something();
            Queen rook2 = new Queen();
            rook2.DoSomething("This is what i thought");
        }
    }
}