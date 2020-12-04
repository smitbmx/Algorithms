﻿using System;
using System.Collections.Generic;

namespace GradingStudentsRound
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            foreach (var grade in grades)
            {
                if (grade < 38 || grade % 5 < 3)
                {
                    roundedGrades.Add(grade);
                }
                else if (grade % 5 > 2)
                {
                    int add = 5 - (grade % 5);
                    roundedGrades.Add(grade + add);
                }
            }

            return roundedGrades;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
