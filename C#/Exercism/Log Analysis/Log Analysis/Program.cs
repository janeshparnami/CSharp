using Log_Analysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(LogAnalysis.SubstringBetween("[INFO]: File Deleted.", "[", "]"));
        Console.WriteLine("[WARNING]: Library is deprecated.".Message());
    }
}