using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 10)
            {
                Console.WriteLine("SMOL NUMBER");
            }
            else if (x > 0)
            {
                Console.WriteLine("definitely bigger than 0");
            }
            else if (x > -50)
            {
                Console.WriteLine("NOT TOO BIG OF A NEGATIVE ONE");
            }

            Console.WriteLine("THE END");



            Console.Write($"Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 50)
            {
                Console.WriteLine("Bigger");
            }
            else if (number == 50)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("LOWER");
            }


            //another example of multiple if-statements in a row
            if (number < 50)
            {
                Console.WriteLine("S");
            }
            if (number == 50)
            {
                Console.WriteLine("50 is 50");
            }
            else
            {
                Console.WriteLine("BIG");
            }

            Console.WriteLine("\n-----------------------\n");

            //couple of options of how to structure your if-statements
            //option 2

            if (number < 50)
            {
                Console.WriteLine("smaller than 50");
            }
            else
            {
                if(number == 50)
                {
                    Console.WriteLine("equal to 50");
                }
                else
                {
                    Console.WriteLine("bigger than 50");
                }
            }
            Console.WriteLine("\n-----------------------\n");
            //option3 combining if-statements
            if (number != 50)
            {
                if (number > 50)
                {
                    Console.WriteLine("LARGE");
                }
                else
                {
                    Console.WriteLine("SMALL");
                }
            }
            else
            {
                Console.WriteLine("EXACTLY 50");
            }

            Console.WriteLine("\n-----------------------\n");

            //option 4
            if (number > 50)
            {
                if (number < 100)
                {
                    Console.WriteLine($"{number} is still below 100");
                }
                else
                {
                    Console.WriteLine($"{number} is massive");
                }
            }
            else
            {
                if (number == 50)
                {   
                    Console.WriteLine("Perfectly 50");
                }
                else
                {
                    Console.WriteLine("Obviously smaller");
                }
            }

            Console.WriteLine("\n-----------------------\n");
            //combining conditions and checks
            // --> combination operators = && || !() 
            //check if the number is (not) equal to 100
            // OPTION 1

            if (number == 100)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.WriteLine("\n-----------------------\n");

            //option2
            if (number < 100 || number > 100)
            {
                Console.WriteLine("Number is not equal to 100");
            }
            else
            {
                Console.WriteLine("Number is exactly 100");
            }
            Console.WriteLine("\n-----------------------\n");

            //option 3
            if (number != 100)
            {
                Console.WriteLine("NOPE");
            }
            else
            {
                Console.WriteLine("YEP");
            }
            Console.WriteLine("\n-----------------------\n");

            //option 4
            if (!(number == 100))
            {
                Console.WriteLine("not 100");
            }
            else
            {
                Console.WriteLine("100");
            }

            Console.WriteLine("more difficult conditions");

            //option 5
            if (!(number < 100) && !(number > 100))
            {
                Console.WriteLine("100 precisely");
            }
            else
            {
                Console.WriteLine("not 100");
            }

            //option 6
            bool condition = number != 100;
            if (condition) //condition == true
            {
                Console.WriteLine("condition and number are not 100");
            }
            else
            {
                Console.WriteLine("condition and number are 100");
            }
            
            //option 7
            if (!condition)
            {
                Console.WriteLine("condition and number are 100");
            }
            else
            {
                Console.WriteLine("condition and number are not 100");
            }


        }
    }
}