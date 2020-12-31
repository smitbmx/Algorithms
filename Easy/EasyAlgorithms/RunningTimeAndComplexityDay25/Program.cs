using System;
using System.Collections.Generic;

namespace RunningTimeAndComplexityDay25
{
    class Solution
    {
        public static bool isPrime(int n)
        {
            int sqrtN = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrtN; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(String[] args)
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 2 && isPrime(number))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}
