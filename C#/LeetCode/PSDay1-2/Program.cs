namespace PSDay1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PS Day1 Pb2 - 1491(Easy)
            //SalaryCalulation
            float avgSal = SalaryCalculation.AverageSalary(new int[] { 4000, 3000, 1000, 2000});
            Console.WriteLine(avgSal);

            //PS Day2 Pb1 - 191(Easy)
            int value = Num1Bits.HammingWeight(15);
            Console.WriteLine(value);

            //PS Day2 Pb2 - 1281(Easy)
            int diff = ProductMinusSum.SubtractProductAndSum(1);
            Console.WriteLine(diff);
        }
    }
}