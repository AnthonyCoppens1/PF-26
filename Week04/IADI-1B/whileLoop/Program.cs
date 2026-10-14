using System;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Start! press y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.WriteLine($"press y to continue: ");
                answer = Console.ReadLine();
            }



            //password checker
            Console.WriteLine("Enter your password:");
            string PW = Console.ReadLine();
            int count = 0;

            while (PW != "password")
            {
                Console.WriteLine(count);
                if (count < 3)
                {
                    Console.WriteLine("Your password was wrong, enter again: ");
                    count++;
                    PW = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            if (count >= 3)
            {
                Console.WriteLine("FAILED? NO ACCESS");
            }
            else
            {
                Console.WriteLine("You've logged in correctly");
            }


            //guessing game
            Random randomGame = new Random();
            int number = randomGame.Next(1, 3);

            Console.Write($"Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int attempts = 1;

            while (number != guess)
            {
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Higher");
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                }
            }

            Console.WriteLine($"Good job, you've used {attempts} attempt(s)");



            //sequences 3 6 9 12 15 ... max value of a short
            Console.WriteLine("\n sequence of 3 6 9 12 15 ...");
            int i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write($"{i} ");
                i += 3;
            }

            //sequences to check the importance of order of code
            Console.Write("\nEnter a number: ");
            int x = Convert.ToInt32(Console.ReadLine()); //5

            Console.WriteLine("\nSEQUENCE 1");
            i = x;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }

            Console.WriteLine("\nSEQUENCE 2");
            i = x;
            while (i < Int16.MaxValue)
            {
                i *= x;
                Console.Write(i + " ");
            }


            //DO WHILE, WILL ALWAYS LOOP AT LEAST 1 TIME
            Console.WriteLine("\nSEQUENCE 3");
            i = x;
            do
            {
                Console.Write(i + " ");
                i *= x;
            }
            while (i < Int16.MaxValue);


            
        }
    }
}