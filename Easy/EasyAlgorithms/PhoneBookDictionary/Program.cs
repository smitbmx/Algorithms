using System;
using System.Collections.Generic;

namespace PhoneBookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {

                string inputValue = Console.ReadLine();
                string name = inputValue.Split(' ')[0];
                string phone = "";

                if (inputValue.Split(' ').Length > 1)
                {
                    phone = inputValue.Split(' ')[1];
                }

                phoneBook.Add(name, phone);

            }

            string lookupKey;
            while ((lookupKey = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(lookupKey))
                {
                    Console.WriteLine(string.Format("{0}={1}", lookupKey, phoneBook[lookupKey]));
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            Console.ReadLine();
        }
    }
}
