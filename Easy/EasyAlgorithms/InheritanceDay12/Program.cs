using System;
using System.Linq;

namespace InheritanceDay12
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;
        private string firstName;
        private string lastName;
        private int id;

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName);
            Console.WriteLine("ID: " + id);
        }

        public string Calculate()
        {
            string grade = string.Empty;
            int sum = 0;
            foreach (int score in testScores)
            {
                sum += score;
            }

            int avg = sum / testScores.Length;

            if (avg >= 90 && avg <= 100)
            {
                grade = "O";
            }
            else if (avg >= 80 && avg < 90)
            {
                grade = "E";
            }
            else if (avg >= 70 && avg < 80)
            {
                grade = "A";
            }
            else if (avg >= 55 && avg < 70)
            {
                grade = "P";
            }
            else if (avg >= 40 && avg < 55)
            {
                grade = "D";
            }
            else if (avg < 40)
            {
                grade = "T";
            }


            return grade;
        }

    }

    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}
