using System;

namespace LogAllPairsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1,2,3,4,5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        Console.WriteLine(numbers[i] + " " + numbers[j]);
                    }
                }
            }

            Console.ReadLine(); 
        }
    }
}
