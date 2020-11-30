using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Alex works at a clothing store. There is a large pile of socks that must be paired by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
///For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .
/// </summary>
namespace SalesByMatch
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int matchingPairs = 0;
            List<int> lst = new List<int>();

            foreach (var sock in ar)
            {
                if (lst.Contains(sock))
                {
                    matchingPairs++;
                    lst.Remove(sock);
                }
                else
                {
                    lst.Add(sock);
                }
            }

            return matchingPairs;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}
