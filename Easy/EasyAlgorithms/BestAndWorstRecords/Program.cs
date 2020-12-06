using System;

namespace BestAndWorstRecords
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int[] result = new int[2];
            int maxRecord = 0;
            int minRecord = 0;
            int maxTemp = 0;
            int minTemp = 0;

            int i = 0;
            foreach (int score in scores)
            {
                if (i == 0)
                {
                    maxTemp = score;
                    minTemp = score;
                }

                if (score > maxTemp)
                {
                    maxTemp = score;
                    maxRecord++;
                }
                else if (score < minTemp)
                {
                    minTemp = score;
                    minRecord++;
                }

                i++;
            }

            result[0] = maxRecord;
            result[1] = minRecord;

            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));

            Console.ReadKey();
        }
    }
}
