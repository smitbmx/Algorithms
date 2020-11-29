using System;
using System.Collections.Generic;

/// <summary>
/// Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.
///The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).
/// </summary>
namespace CompareTheTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int AlicePoints = 0;
            int BobPoints = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    AlicePoints += 1;
                }
                else if (a[i] < b[i])
                {
                    BobPoints += 1;
                }
            }

            result.Add(AlicePoints);
            result.Add(BobPoints);

            return result;
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 17, 28, 30 };

            List<int> b = new List<int> { 99, 16, 8 };

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }
}
