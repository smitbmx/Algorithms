using System;
using System.Linq;

namespace ScopeDay14V2
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] numbers)
        {
            this.elements = numbers;
        }

        public void computeDifference()
        {
            int min = elements[0];
            int max = elements[0];

            foreach (int number in elements)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            maximumDifference = max - min;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
