using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenOddSplitInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> arr = new List<string>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd());
            }

            foreach (var item in arr)
            {
                string even = "";
                string odd = "";

                for (int i = 0; i < item.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even += item[i].ToString();
                    }
                    else
                    {
                        odd += item[i].ToString();
                    }
                }

                Console.WriteLine(even + " " + odd);
            }
            
            
        }
    }
}
