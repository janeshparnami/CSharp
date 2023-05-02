namespace Bird_Watcher
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BirdCount birds = new BirdCount(new int[] { 4, 9, 5, 7, 8, 8, 2 });
			Console.WriteLine(birds.BusyDays());
		}
	}
}