using System;
using System.Linq;

namespace ScopeDay14
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] numbers)
        {
            this.elements = numbers;
        }

        public void computeDifference()
        {
            maximumDifference = this.elements.Max() - this.elements.Min();
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
