using System;
using System.Collections.Generic;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        public static void Calculator()
        {
            Console.Write("How many employees?");
            int N = Int32.Parse(Console.ReadLine());

            var employees = new string[N];
            var salaries = new double[N];
            var ratings = new List<int[]>();

            ReadArray(N, employees, salaries, ratings);
            WriteArray(N, employees, salaries, ratings);
        }

        private static void WriteArray(int N, string[] employees, double[] salaries, List<int[]> ratings)
        {
            Console.WriteLine("Names\t\tQ1\tQ2\tQ3\tQ4\tOverall Rating\tExpected Salary\t\tPerformance");
            var overall_ratings = new double[N];
            var printOuts = new Dictionary<double, string>();

            for (int i = 0; i < N; i++)
            {
                var overallRating = GetRating(ratings[i]);
                var salaryIncrease = salaries[i] * (overallRating / 100);
                var expectedSalary = salaries[i] + salaryIncrease;
                var performance = GetPerformance(overallRating);

                overall_ratings[i] = overallRating;

                string printOut = String.Format("{0}\t\t{1}\t{2}\t{3}\t{4}\t{5:F}\t\t${6}\t\t{7}\n",
                    employees[i], ratings[i][0], ratings[i][1], ratings[i][2], ratings[i][3],
                    overallRating, expectedSalary, performance);

                printOuts[overallRating] = printOut;
            }

            //sort in ascending order
            Array.Sort(overall_ratings);
            // then reverse to descending order
            Array.Reverse(overall_ratings);

            // print all element of array 
            foreach (double value in overall_ratings)
            {
                Console.WriteLine(printOuts[value]);
            }
        }

        private static object GetPerformance(double overallRating)
        {
            if (overallRating >= 7)
                return "BEST";
            if (overallRating >= 5 && overallRating < 7)
                return "AVERAGE";
            return "ON-TRACK";
        }

        private static double GetRating(int[] employee_ratings)
        {
            double total = 0;
            foreach(int rating in employee_ratings)
            {
                total += rating;
            }
            return (total / 4);
        }

        private static void ReadArray(int N, string[] students, double[] salaries, List<int[]> ratings)
        {
            for (int i = 0; i < N; i++)
            {
                int k = i + 1;
                Console.WriteLine("Enter the name of employee " + k);
                string name = Console.ReadLine();
                students[i] = name;
                Console.WriteLine("Enter " + name + "'s current salary");
                salaries[i] = Int32.Parse(Console.ReadLine());

                var emp_ratings = new int[4];
                for(int j = 0; j <  4; j++)
                {
                    int rating;
                    do
                    {
                        Console.WriteLine("Enter " + name + "'s mark for Q" + j.ToString());
                        rating = Int32.Parse(Console.ReadLine());
                        emp_ratings[j] = rating;
                    }
                    while (rating > 10);
                }
                ratings.Add(emp_ratings);
            }
        }
    }
}
