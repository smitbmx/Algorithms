using System;
using System.Collections.Generic;

namespace OddNumbersInRange
{
    class Program
    {
        public static List<int> oddNumbers(int l, int r)
        {
            List<int> oddNumbersInRange = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbersInRange.Add(i);
                }
            }

            return oddNumbersInRange;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var oddNumbersResult = oddNumbers(3, 9);

            foreach (var number in oddNumbersResult)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
