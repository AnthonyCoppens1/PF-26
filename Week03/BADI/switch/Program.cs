using System;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekdag = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekdag);

            string dagNaam = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dagNaam);

            DateTime dag = new DateTime(2026, 10, 9);
            Console.WriteLine(dag.DayOfYear);
            Console.WriteLine(dag.AddDays(100).DayOfWeek.ToString());

            switch (weekdag) //geheel getal
            {
                case 1:
                    Console.WriteLine("boooo, weekend voorbij");
                    break;
                case 2:
                    Console.WriteLine("we zijn vertrokken, het is dinsdag");
                    break;
                case 3:
                    Console.WriteLine("WOENSDAG");
                    break;
                case 4:
                    Console.WriteLine("bijna daar");
                    break;
                case 5:
                    Console.WriteLine("praktisch gezien weekend WOHOOOOOOOOOOOOOOOOOOOOO");
                    break;
                default:
                    Console.WriteLine("leuke dag");
                    break;
            }


            switch (dagNaam) //TEKST
            {
                case "Friday":
                    Console.WriteLine("boooo, weekend voorbij");
                    break;
                case "friday":
                    Console.WriteLine("TEST");
                    break;
                case "Sunday":
                    Console.WriteLine("we zijn vertrokken, het is dinsdag");
                    break;
                default:
                    Console.WriteLine("leuke dag");
                    break;
            }

            /*
            Ask for the total bill (DOUBLE, e.g. 87,45), the number of people, and a service rating from 1–5. 
            The rating sets the tip percentage through a switch (1 → 0%, 2 → 5%, 3 → 10%, 4 → 15%, 5 → 20%).

            Calculate the tip, the total, and the amount per person.
            Round each person’s share up to the nearest 50 cents (Math.Ceiling(amount * 2) / 2), 
            then show how much extra the group pays because of the rounding.
            If the per-person share is over €50, print a warning.*/
            

        }
    }
}