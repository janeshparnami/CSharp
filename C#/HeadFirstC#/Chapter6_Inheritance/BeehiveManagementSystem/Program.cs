namespace BeehiveManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queen queen= new Queen();
            queen.WorkTheNextShift();
            queen.AssignBee("Egg Care");
            string statusReport = queen.StatusReport;
            Console.WriteLine(statusReport);
        }
    }
}