using System;

namespace ExercisesOnIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX 1
            /*Ask the user for their own birthyear and calculate the age of the person based on the difference
            between their birthyear and the current year. Grab the current year using the DateTime class
            
            Depending on the age, prompt the user with a correct message fo what they're legally allowed
            to drink in Belgium: 
            16+ - wine and beer 
            18+ strong alcohol 
            below 16: alternative (pick yourself)
            */

            int birthyear = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Now.Year;

            int age = currentYear - birthyear;
            
            if (age >= 18)
            {
                Console.WriteLine("You're good to go with the stuff even though we all know you've been " +
                "drinking it since you were 14");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Beer and wine and mighty fine");
            }
            else if (age >= 0)
            {
                Console.WriteLine("Milk and apple juice together with water!");
            }
            else
            {
                Console.WriteLine("You don't exist");
            }



            //EX 2
            /*Read in 2 names (of people?) and generate a random love percentage for them (double) using
            the class Random. Depending on the love % they have, output a fitting message about their love. 
            */
            Console.WriteLine("LOVE CALCULATOR");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            Random r = new Random();
            double lovePercentage = r.NextDouble(); //a double between 0 and 1 --> 0.725617892
            lovePercentage = lovePercentage * 100;

            if (lovePercentage > 75)
            {
                Console.WriteLine($"{name1} and {name2} are madly in love with a "+
                $"percentage of {lovePercentage:F2}%, go make babies, if possible");
            }
            else if (lovePercentage > 50)
            {
                Console.WriteLine($"{name1} and {name2} you're doing okay, but I have my doubts with a "+
                $"percentage of {lovePercentage:F2}%, seek a therapist!");
            }
            else
            {
                Console.WriteLine($"{name1} and {name2}, with a percentage of {lovePercentage:F2}%, "
                + "might as well call it quits, no hope, failed marriage, divorce time, HOPELESS, broken heart");
            }

        }
    }
}