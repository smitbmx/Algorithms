using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }

        static string timeConversion(string s)
        {
            string hours = s.Split(':')[0];
            string minutes = s.Split(':')[1];
            string seconds = s.Split(':')[2].Substring(0,2);
            string partOfTheDay = s.Split(':')[2].Substring(2, 2);
            int convertedHours = Convert.ToInt32(hours);
            string resHours = string.Empty;

            if (partOfTheDay == "PM" && convertedHours != 12)
            {
                convertedHours += 12;
                resHours = convertedHours.ToString();
            }
            else
            {
                resHours = hours.ToString();
            }

            if (partOfTheDay == "AM" && convertedHours == 12)
            {
                resHours = "00";
            }

            string result = string.Format("{0}:{1}:{2}", resHours, minutes,seconds);

            return result;
        }
    }
}
