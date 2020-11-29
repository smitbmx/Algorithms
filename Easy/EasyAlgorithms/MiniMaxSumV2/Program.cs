using System;
using System.Linq;

namespace MiniMaxSumV2
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        { 
            long maxValue = arr.Max();
            long minValue = arr.Min();
            long sumValue = arr.Sum();

            long miniSum = sumValue - maxValue;
            long maxSum = sumValue - minValue;

            Console.WriteLine(miniSum + " " + maxSum);
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);

            Console.WriteLine();
        }
    }
}
