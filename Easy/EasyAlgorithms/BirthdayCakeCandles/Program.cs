using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.
/// Candles = [4,4,1,3]
/// The maximum height candles are  units high. There are  of them, so return .
/// </summary>
namespace BirthdayCakeCandles
{
    class Result
    {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            int result = 0;

            int maxAge = candles.Max();

            result = candles.Where(c => c == maxAge).Count();

            return result;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            Console.WriteLine(result);
        }
    }
}
