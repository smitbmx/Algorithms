using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace SubArraysSums
{
    class Result
    {

        /*
         * Complete the 'findSum' function below.
         *
         * The function is expected to return a LONG_INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY numbers
         *  2. 2D_INTEGER_ARRAY queries
         */


        //TODO: it's not optimized for large numbers
        public static List<long> findSum(List<int> numbers, List<List<int>> queries)
        {
            List<long> res = new List<long>();

            foreach (List<int> query in queries)
            {
                int l = query[0];
                int r = query[1];
                int x = query[2];

                long sum = 0;
                for (int i = l - 1; i < r; i++)
                {
                    sum += numbers[i];

                    if (numbers[i] == 0)
                    {
                        sum += x;
                    }
                }

                res.Add(sum);
            }

            return res;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> numbers = new List<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
                numbers.Add(numbersItem);
            }

            int queriesRows = Convert.ToInt32(Console.ReadLine().Trim());
            int queriesColumns = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < queriesRows; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<long> result = Result.findSum(numbers, queries);

            Console.WriteLine(String.Join("\n", result));

            Console.ReadKey();
        }
    }
}
