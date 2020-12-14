using System;
using System.Collections.Generic;
using System.Linq;

namespace Hourglass2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            List<int> sums = new List<int>();
            for (int y = 1; y < arr.Length - 1; y++)
            {
                for (int x = 1; x < arr.Length - 1; x++)
                {
                    int sum = arr[y - 1][x - 1] + arr[y - 1][x] + arr[y - 1][x + 1]
                                                + arr[y][x]
                            + arr[y + 1][x - 1] + arr[y + 1][x] + arr[y + 1][x + 1];

                    sums.Add(sum);
                }
            }

            Console.WriteLine(sums.Max());
            Console.ReadLine();
        }
    }
}
