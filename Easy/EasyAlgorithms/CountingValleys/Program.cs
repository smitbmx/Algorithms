using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 8;
            string path = "UDDDUDUU";

            int result = Result.countingValleys(steps, path);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    class Result
    {

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int countingValleys = 0;
            int startLevel = 0;
            int currentLevel = startLevel;

            foreach (var step in path)
            {
                int previousStep = currentLevel;

                if (step == 'U')
                {
                    currentLevel += 1;
                }
                else if(step == 'D')
                {
                    currentLevel -= 1;
                }


                if (currentLevel < 0 && previousStep == 0)
                {
                    countingValleys += 1;
                }
            }

            return countingValleys;
        }

    }
}
