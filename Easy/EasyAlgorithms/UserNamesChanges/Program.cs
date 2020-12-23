using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace UserNamesChanges
{
    class Result
    {

        /*
         * Complete the 'possibleChanges' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts STRING_ARRAY usernames as parameter.
         */

        public static List<string> possibleChanges(List<string> usernames)
        {
            List<string> res = new List<string>();
            foreach (string username in usernames)
            {
                bool canSwap = false;
                for (int j = 0; j < username.Length - 1; j++)
                {
                    char next = username[j + 1];
                    char current = username[j];
                    if (next < current)
                    {
                        res.Add("YES");
                        canSwap = true;
                        break;
                    }
                }

                if (!canSwap)
                {
                    res.Add("NO");
                }
            }

            return res;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int usernamesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> usernames = new List<string>();

            for (int i = 0; i < usernamesCount; i++)
            {
                string usernamesItem = Console.ReadLine();
                usernames.Add(usernamesItem);
            }

            List<string> result = Result.possibleChanges(usernames);

            Console.WriteLine(String.Join("\n", result));

            Console.ReadKey();
        }
    }
}
