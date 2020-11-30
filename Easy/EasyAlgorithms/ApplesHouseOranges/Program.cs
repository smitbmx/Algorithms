using System;

/// <summary>
/// https://www.hackerrank.com/challenges/apple-and-orange/problem
/// </summary>
namespace ApplesHouseOranges
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int landedApples = 0;
            int landedOranges = 0;

            foreach (var apple in apples)
            {
                //House range
                if (a + apple >= s && a + apple <= t)
                {
                    landedApples += 1;
                }
            }

            foreach (var orange in oranges)
            {
                //House range
                if (b + orange <= t && b + orange >= s)
                {
                    landedOranges += 1;
                }
            }

            Console.WriteLine(landedApples);
            Console.WriteLine(landedOranges);
        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
