using System;
using System.Linq;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string twoBase = Convert.ToString(n,2);

            int i = 0;
            int max1InRow = 0;
            foreach (char c in twoBase)
            {
                if (c == '1')
                {
                    i++;

                    if (i > max1InRow)
                    {
                        max1InRow = i;
                    }
                }
                else
                {
                    i = 0;
                }
            }

            Console.WriteLine(max1InRow);

            Console.ReadLine();
        }
    }
}
