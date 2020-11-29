using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            arr.Add("11 2 4".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("4 5 6".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("10 8 -12".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagonalDifference = 0;

            int lrd = 0;
            int rld = 0;
            int inc = 0;
            int dcr = arr.Count;
            for (int i = 0; i < arr.Count; i++)
            {
                lrd += arr[i][inc++];
                rld += arr[i][--dcr];
            }

            diagonalDifference = Math.Abs(lrd - rld);

            return diagonalDifference;
        }

    }
}
