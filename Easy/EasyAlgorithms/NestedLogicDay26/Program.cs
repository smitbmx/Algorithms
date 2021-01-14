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

            if (yearReturned == dueYearReturned)
            {
                if (monthReturned == dueMonthReturned)
                {
                    if (dayReturned == dueDayReturned)
                    {
                        fine = 0;
                    }
                    else
                    {
                        fine = 15 * (dayReturned - dueDayReturned);
                    }
                }
                else if (monthReturned <= dueMonthReturned)
                {
                    fine = 0;
                }
                else
                {
                    fine = 500 * (monthReturned - dueMonthReturned);
                }
            }
            else if (yearReturned < dueYearReturned)
            {
                fine = 0;
            }
            else
            {
                fine = 10000;
            }

            Console.WriteLine(fine);

            Console.ReadLine();
        }
    }
}
