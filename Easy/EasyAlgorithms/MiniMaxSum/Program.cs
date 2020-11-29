using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            List<int> lst = new List<int>();

            foreach (var item in arr)
            {
                lst.Add(item);
            }

            lst.Sort();

            var mini = lst.Take(arr.Length-1);
            var max = lst.Skip(1);

            long miniSum = 0;
            long maxSum = 0;

            foreach (var item in mini)
            {
                miniSum += item;
            }

            foreach (var item in max)
            {
                maxSum += item;
            }

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
