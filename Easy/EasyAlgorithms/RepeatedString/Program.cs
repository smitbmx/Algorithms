using System;
using System.Linq;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            char charToSearch = 'a';
            long amountOfFullSubstrings = n / s.Length;
            long remainder = n - amountOfFullSubstrings * s.Length;
            string remainderStr = s.Substring(0, (int)remainder);

            long countOfCharInString = s.Count(c => c == charToSearch);
            long result = countOfCharInString * amountOfFullSubstrings + remainderStr.Count(c => c == charToSearch);

            return result;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
