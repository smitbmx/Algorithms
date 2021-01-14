using System;
using System.Collections.Generic;

namespace NestedLogicDay26
{
    class Program
    {
        static void Main(string[] args)
        {

            int fine = 0;

            string dateReturned = Console.ReadLine();
            string dueDate = Console.ReadLine();

            int dayReturned = Convert.ToInt32(dateReturned.Split(' ')[0]);
            int monthReturned = Convert.ToInt32(dateReturned.Split(' ')[1]);
            int yearReturned = Convert.ToInt32(dateReturned.Split(' ')[2]);

            int dueDayReturned = Convert.ToInt32(dueDate.Split(' ')[0]);
            int dueMonthReturned = Convert.ToInt32(dueDate.Split(' ')[1]);
            int dueYearReturned = Convert.ToInt32(dueDate.Split(' ')[2]);



            Console.WriteLine(fine);

            Console.ReadLine();
        }
    }
}
