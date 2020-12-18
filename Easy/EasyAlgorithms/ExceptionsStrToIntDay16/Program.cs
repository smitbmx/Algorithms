using System;

namespace ExceptionsStrToIntDay16
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(Convert.ToInt32(S));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }
            

            Console.ReadKey();
        }
    }
}
