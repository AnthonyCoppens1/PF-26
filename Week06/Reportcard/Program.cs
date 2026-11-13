using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            French / Math / Biology / Chemistry / Sports / Dutch

            {{all grades for french test 1}, {all grades for french test 2}, {all grades for french test 3}, {all grades for french test 4}}
            {{15, 6, 1, 19, 12}, {0, 0, 0, 10, 20}, {all grades for french test 3}, {all grades for french test 4}}


            Try to pauze the video, and build your own report card. Have a teacher be able to enter the grades for all the students of a 
            given test. The teacher needs to be able to specify beforehand how many students they have as well as how many tests they've given
            throughout the semester.

            after the base structure and allowing the teacher to fill in the results.
            Code a way of how we can calculate the average for every student as well as the average for every test.
            */

            Console.Write($"Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            int[,] reportcard = new int[tests, students]; 
            //test1: {1, 15, 28, 3, 8}
            //test2: {4, 18, 20, 1, 2}

            for (int i = 0; i < tests; i++)
            {
                for (int j = 0; j < students; j++)
                {
                    Console.Write($"Grade for test {i + 1} of student {j + 1}: ");
                    reportcard[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            /*For me to check what our results look like right now
            for (int i = 0; i < tests; i++)
            {
                for (int j = 0; j < students; j++)
                {
                    Console.Write(reportcard[i,j] + " ");
                }
                Console.WriteLine();
            }*/

            //average for every student
            for (int i = 0; i < students; i++)
            {
                int sum = 0;
                for (int j = 0; j < tests; j++)
                {
                    sum += reportcard[j,i];
                }
                Console.WriteLine($"average for student {i + 1} is {sum / tests}");   
            }

            //average for every test
            for (int i = 0; i < tests; i++)
            {
                int sum = 0;
                for (int j = 0; j < students; j++)
                {
                    sum += reportcard[i,j];
                }
                Console.WriteLine($"average for test {i + 1} is {sum / students}");   
            }




        }
    }
}