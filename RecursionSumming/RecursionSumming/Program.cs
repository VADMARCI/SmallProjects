using System;

namespace RecursionSumming
{
    class Program
    {
        static int SumOfTen(int min, int max)
        {
            return CalcuSum(min, max);
        }

        static int CalcuSum(int min, int val)
        {
            if (val == min)
            {
                return val;
            }
            return val + CalcuSum(min, val - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number n you want to get the sum of");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is: {0}", SumOfTen(1,y));
        }
    }
}
