using System;

namespace CamelCase
{
    class Program
    {
        static int camelcase(string s)
        {
            int wordAmount = 0;
            int theFirstWord = 1;

            foreach (Char c in s)
            {
                if (Char.IsUpper(c))
                {
                    wordAmount++;
                }
            }

            return wordAmount + theFirstWord;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelcase(s);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
