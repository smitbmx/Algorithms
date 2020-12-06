using System;

namespace ReverseArrayV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] res = reverseArray(arr);

            Console.WriteLine(string.Join(" ", res));
        }

        static int[] reverseArray(int[] a)
        {
            int[] reversedArray = new int[a.Length];
            int j = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                reversedArray[j] = a[i];
                j++;
            }

            return reversedArray;
        }
    }
}
