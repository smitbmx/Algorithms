using System;

namespace RightAlignedStaircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);

            Console.ReadKey();
        }

        static void staircase(int n)
        {
            string empty = " ";
            string stair = "#";

            int emptyMap = n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < emptyMap)
                    {
                        Console.Write(empty);
                    }
                    else
                    {
                        Console.Write(stair);
                    }
                }

                emptyMap--;

                Console.WriteLine();
            }
        }
    }
}
