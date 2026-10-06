using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Read in the birthyear of a person and calculate their age based upon
            the difference between actual year and birthyear
            Then with an if-statement indicate what they can drink:
            16+ beer and wine
            18+ strong alcohol
            -16 alternative piece of text*/

            int currentYear = DateTime.Now.Year;
            int birthyear = Convert.ToInt32(Console.ReadLine());
            int age = currentYear - birthyear;

            if (age >= 18)
            {
                Console.WriteLine("STRONG ALCOHOL");
            }
            else if (age >= 16)
            {
                Console.WriteLine("BEER OR WINE");
            }
            else if (age < 16 && age >= 0)
            {
                Console.WriteLine("No alcohol for you, possibly you are an infant??");
            }
            else
            {
                Console.WriteLine("You can never be of a negative age");
            }


            /*LOVE CALCULATOR*/
            Random r = new Random();
            int lovePercentage = r.Next(0,101);
            Console.WriteLine($"Your love is {lovePercentage}");
            if (lovePercentage >= 80)
            {
                Console.WriteLine("They are in love");
            }
            else if (lovePercentage >= 50)
            {
                Console.WriteLine($"Think about it, there's plenty of fish in the sea, "+
                $"but be careful that you don't drown");
            }
            else
            {
                Console.WriteLine("There's no hope for you, lost cause, maybe try a hair transplant" +
                " in some foreign country ");
            }
            
        }
    }
}