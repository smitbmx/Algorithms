using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            plusMinus(arr);

            Console.ReadLine();
        }

        //+, -, 0
        static void plusMinus(int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            double[] res = new double[3];
            int arrLength = arr.Length;
            int roundFractionTo = 6;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    positive += 1;
                }
                else if (item < 0)
                {
                    negative += 1;
                }
                else
                {
                    //item == 0
                    zero += 1;
                }
            }

            res[0] = Math.Round((double)positive / arrLength, roundFractionTo);
            res[1] = Math.Round((double)negative / arrLength, roundFractionTo);
            res[2] = Math.Round((double)zero / arrLength, roundFractionTo);

            Console.WriteLine(String.Format("{0:0.000000}",res[0]));
            Console.WriteLine(String.Format("{0:0.000000}", res[1]));
            Console.WriteLine(String.Format("{0:0.000000}", res[2]));
        }
    }
}
