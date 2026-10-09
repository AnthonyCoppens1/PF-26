using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //base example of the syntax of if-statements
            int x = Convert.ToInt32(Console.ReadLine());

            //check if the given number is equal to, above or below 100

            if (x < 100) // x < 100 == true
            {
                Console.WriteLine("smaller than 100");
            }
            else if (x == 100)
            {
                Console.WriteLine("Equal to 100");
            }
            else
            {
                Console.WriteLine("Bigger than 100");
            }

            Console.WriteLine();

            if (x > 100)
            {
                Console.WriteLine("bigger");
            }
            if (x < 100)
            {
                Console.WriteLine("smaller");
            }
            else
            {
                Console.WriteLine("equal");
            }

            int number = 19;

            if (number > 15)
            {
                Console.WriteLine("Good score");
            }
            else if (number > 10)
            {
                Console.WriteLine("You've passed");
            }
            else  if (number > 5)
            {
                Console.WriteLine("Getting smaller");
            }
            else if (number > 0)
            {
                Console.WriteLine("Positive");
            }

            Console.WriteLine();
            //some variants of the bigger, smaller or equal to 100 if-statement
            //option 2

            if (x < 100)
            {
                Console.WriteLine("smaller than 100");
            }
            else
            {
                if (x == 100)
                {
                    Console.WriteLine("equal to 100");
                }
                else
                {
                    Console.WriteLine("bigger than 100");
                }
            }


            //option 3
            if (x != 100) //anything different from 10à
            {
                if (x > 100)
                {
                    Console.WriteLine("BIG");
                }
                else
                {
                    Console.WriteLine("SMALL");
                }
            }
            else
            {
                Console.WriteLine("EQUAL");
            }

            // 100 or NOT 100
            //option 4
            if (x > 100 || x < 100)
            {
                Console.WriteLine("number is not equal to 100");
            }
            else
            {
                Console.WriteLine("number is EQUAL to 100");
            }

            //option 5
            if (x != 100)
            {
                Console.WriteLine("NO HUNDO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            //option 6
            if (!(x == 100))
            {
                Console.WriteLine("something else than 100");
            }
            else
            {
                Console.WriteLine("You've found the 100");
            }

            //option 7
            if (!(x < 100) && !(x > 100))
            {
                Console.WriteLine("EXACTLY 100");
            }
            else
            {
                Console.WriteLine("Smaller or bigger?");
            }

            //option 8
            string answer = Console.ReadLine();
            //int N;

            bool succes = Int32.TryParse(answer, out int N); //can declare in here or outside
            if (succes) // if it successfully converted
            {
                if (N == 100)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NOT");
                }
            }
            else
            {
                Console.WriteLine("Maybe use a braincell and type an actual integer next time!");
            }



            //option 9
            if (!succes) // if it successfully converted
            {
                Console.WriteLine("failed to convert");
            }
            else
            {
                if (N == 100)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NOT");
                }
            }

        }
    }
}