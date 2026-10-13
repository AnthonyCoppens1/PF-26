using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR LOOPS
            //multiplying a given number by 1, 2, 3, ...
            Console.Write("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //sort of idiotic version
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");
            Console.WriteLine($"{number} * 5 = {number * 5}");
            Console.WriteLine($"{number} * 6 = {number * 6}");
            Console.WriteLine($"{number} * 7 = {number * 7}");

            //efficient and definitely better way
            Console.WriteLine("\n FOR LOOP i=0, i <= 10");

            //int final = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) // do keep in mind, the user can also include a variable as the final condition
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
            

            Console.WriteLine("\n FOR LOOP i=1, i <= 10");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            Console.WriteLine("\n FOR LOOP i=0, i <= 10, stepsize 2");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }


            Console.WriteLine("\n FOR LOOP i=0, i <= 10, stepsize multiply by 2");
            //CAREFUL, IF YOU START AT 0 IT WILL LOOP INFINITELY
            for (int i = 1; i <= 10; i *= 2)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }


            Console.WriteLine("\n FOR LOOP i= 10, i >= 0, i--");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }


            //print 3 6 9 12 15 18 21 ... 33
            for (int i = 3; i <= 33; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // print 3 6 9 12 ... 33 IN A SECOND WAY
            for (int i = 1; i <= 11; i++)
            {
                Console.Write($"{i*3} ");
            }
            Console.WriteLine();

            //print 3 6 9 12 ... 33 in a third way
            for (int i = 1; i <= 33; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }


            //nesting loops --> loop in a loop
            Console.Write($"\n\nEnter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nEnter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //table of the letter J --> starting point will be x = 5 and y = 5
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //table of starts
            Console.WriteLine($"\n Table of starts");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //table of what I prints
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            /*
            1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5         
            */

            x = 3;

            Console.WriteLine($"\nPYRAMID");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            /*
            1.                  3.

            *                            *
            * *                        * *
            * * *                    * * *
            * * * *                * * * *
            * * * * *            * * * * *

            2.                  4.

            * * * * *            * * * * *
            * * * *                * * * *
            * * *                    * * *
            * *                        * *
            *                            *
            
            
            
            
            
            */






        }
    }
}