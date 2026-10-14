using System;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BASE EXAMPLE
            Console.WriteLine($"Start, press y to continue, anything else to stop");
            string answer = Console.ReadLine(); 

            while (answer == "y") //y
            {
                Console.WriteLine("Press y to continue, anything else to stop");
                answer = Console.ReadLine();
            }


            //PASSWORD CHECKER WITH ONLY 3 ATTEMPTS
            Console.WriteLine("Give me your password, you have 3 attempts left!");
            string password = Console.ReadLine();
            int attempts = 3;

            while (password != "UnicornloversUnited67!")
            {
                attempts--;
                Console.WriteLine($"Password was wrong, {attempts} remaining");
                if (attempts <= 0)
                {
                    Console.WriteLine("Failed too many times");
                    break;
                }
                else
                {
                    password = Console.ReadLine();
                }
            }

            if (attempts > 0)
            {
                Console.WriteLine($"DONE, LOGGED IN, {attempts} attempts remaining");
            }
            else
            {
                Console.WriteLine("You absolute fool, ain't no way you are getting access to this amazing account");
            }


            //higher or lower game to test your luck!
            Console.WriteLine("GUESS THE NUMBER, HIGHER OR LOWER!");
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 3);

            int tries = 1;
            int guess = Convert.ToInt32(Console.ReadLine());

            while (number != guess)
            {
                if (guess < number)
                {
                    Console.WriteLine("HIGHER!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    tries++;
                }
                else
                {
                    Console.WriteLine("LOWER!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    tries++;
                }
            }

            Console.WriteLine($"The number was {number}, you guessed it in: {tries} tries");


            //order of your code
            //sequence of 3 9 81 273 ... MAX VALUE OF A SHORT
            Console.WriteLine("SEQUENCE 1");
            int i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write($"{i} ");
                i *= 3;
            }

            Console.WriteLine("\nSEQUENCE 2");
            i = Convert.ToInt32(Console.ReadLine());
            while (i < Int16.MaxValue)
            {
                i *= 3;
                Console.Write($"{i} ");
            }


            Console.WriteLine("\nSEQUENCE 3 WITH A DO");
            do
            {
                Console.Write($"{i} ");
                i *= 3;
            }
            while (i < Int16.MaxValue);



            /*
            FINAL exercise on loops
            combination of for and while

            magical numbers:
            Read in a integer given by the user, separate the number in its digits and take every digit
            multiply it by itself (power of 2) and add them up. If the sum is lower than 10, end the loop
            else keep on repeating the same system with the sum that you've gotten.

            BEWARE: converting a char into a number wil cause it to use the ascii value. go back
            to a string first!
            
            Math.Pow(number, power);
            */


        }
    }
}