using System;
using System.IO;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 4,3,2,4,5,7,8,9,3 };
            int result = simpleArraySum(ar);

            Console.WriteLine(result);
        }

        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
    }
}
