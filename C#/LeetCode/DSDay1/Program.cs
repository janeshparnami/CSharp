namespace DSDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Project -- Contains Duplicate
            bool hasDuplicate = ContainsDuplicate.HasDuplicate(new int[] {0});
            Console.WriteLine(hasDuplicate);

            //Project -- MaximumSubarray
            int[] arr = { -2, -3, -1, 5, -4, 6, 2, -3, 7, -9, -1, 10, 4, -2, -1, 3 };
            MaximumSubarray maxSub = new();
            Console.WriteLine(maxSub.MaxSumSubarray(arr));
        }
    }
}