using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Give me a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //the not so great/ slightly idiotic version
            Console.WriteLine($"{x} * 1 = {x * 1}");
            Console.WriteLine($"{x} * 2 = {x * 2}");
            Console.WriteLine($"{x} * 3 = {x * 3}");
            Console.WriteLine($"{x} * 4 = {x * 4}");
            Console.WriteLine($"{x} * 5 = {x * 5}");
            Console.WriteLine($"{x} * 6 = {x * 6}");
            Console.WriteLine();

            //the way better way with using a loop
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }

            Console.WriteLine($"\n\nFOR LOOP START: i = 1; i <= 10; stepsize 1");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }

            
            Console.WriteLine($"\n\nFOR LOOP START: i = 0; i <= 10; stepsize 2");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }

            int secondNumber = 0;

            Console.WriteLine($"\n\nFOR LOOP START: i = 1; i <= 10; stepsize 2");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
                secondNumber++;
                int test = 12;
            }

            Console.WriteLine(secondNumber);
            //Console.WriteLine(test);

            

            // BE CAREFUL, STARTING AT 0 HERE IS GOING TO CAUSE AN INFINITE LOOP! 0 * 2 = 0
            Console.WriteLine($"\n\nFOR LOOP START: i = 0; i <= 10; stepsize MULTIPLY 2");
            for (int i = 1; i <= 10; i *= 2)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }


            Console.WriteLine($"\n\nFOR LOOP START: i = 10; i >= 0; i--");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
            Console.WriteLine();



            //print out the sequence: 3 6 9 12 15 18 ... 33
            for (int i = 3; i <= 33; i += 3)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            //print out the sequence: 3 6 9 12 15 18 ... 33 IN A SECOND WAY
            for (int i = 1; i <= 33; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            //NESTING LOOPS
            Console.Write($"Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++) //5
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            } 

            Console.WriteLine();
            for (int i = 0; i < x; i++) //5
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            } 


            /*
            * * *
            * * *
            * * *
        


            *
            * *
            * * *
            * * * *
            */

            Console.WriteLine($"PYRAMID TIME");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            /*
            4 PYRAMIDS
            1.              3.
            *                       *
            * *                   * *
            * * *               * * *
            * * * *           * * * *
            * * * * *       * * * * *

            2.              4.
            * * * * *       * * * * *
            * * * *           * * * *
            * * *               * * *
            * *                   * *
            *                       *
            
            */


            //1
            Console.WriteLine("$PYRAMID 1");
            x = 5;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //2
            Console.WriteLine($"PYRAMID 2");
            for (int i = 0; i < x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            //3
            Console.WriteLine($"PYRAMID 3");
            for (int i = 1; i <= x; i++) //CAREFUL, IF I STARTS AT 0, IT WILL PRINT AN EMPTY ROW
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write($"  ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            //4
            Console.WriteLine($"PYRAMID 4");
            for(int i = 1; i <= x; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = x; k >= i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}