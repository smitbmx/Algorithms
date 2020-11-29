using System;

namespace ReverseArray
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
            int lastIndex = a.Length-1;

            for (int i = 0; i < a.Length; i++)
            {
                reversedArray[i] = a[lastIndex];
                lastIndex--;
            }

            return reversedArray;
        }
    }
}
