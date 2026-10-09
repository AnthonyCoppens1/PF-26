using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-statements, checken of een bepaald getal groter, gelijk of kleiner
            //dan 200 is.

            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal < 200)
            {
                Console.WriteLine("kleiner");
            }
            else if (getal == 200)
            {
                Console.WriteLine("Gelijk");
            }
            else
            {
                Console.WriteLine("groter");
            }

            Console.WriteLine();

            // 35
            if (getal < 200)
            {
                Console.WriteLine("kleiner dan 200");
            }
            if (getal > 200)
            {
                Console.WriteLine("groter dan 200");
            }
            else
            {
                Console.WriteLine("gelijk aan 200");
            }

            Console.WriteLine();
            //allereerste if-statement herschrijven, verschillende technieken
            //optie 2
            if (getal < 200)
            {
                Console.WriteLine("ZEER KLEIN");
            }
            else
            {
                if (getal == 200)
                {
                    Console.WriteLine("HELEMAAL GELIJK");
                }
                else
                {
                    Console.WriteLine("VEEL GROTER");
                }
            }
            Console.WriteLine();

            //optie 3
            if (getal != 200)
            {
                if (getal < 200)
                {
                    Console.WriteLine("klein");
                }
                else
                {
                    Console.WriteLine("groot");
                }
            }
            else
            {
                Console.WriteLine("gelijk");
            }


            //opties waarbij we checken of het getal 200 is of niet.
            //optie 4
            if (getal == 200)
            {
                Console.WriteLine("iets");
            }
            else
            {
                Console.WriteLine("niets");
            }

            //optie 5
            // reminder, 3 type symbole: && (en)    || (of)     ! (not)

            if (getal < 200 || getal > 200)
            {
                Console.WriteLine("Niet 200");
            }
            else
            {
                Console.WriteLine("exact 200");
            }

            //optie 6
            if (getal != 200)
            {
                Console.WriteLine("nee");
            }
            else
            {
                Console.WriteLine("Ja");
            }

            //optie 7
            if (! (getal == 200))
            {
                Console.WriteLine("niet 200");
            }
            else
            {
                Console.WriteLine("wel 200");
            }

            //optie 8
            if (!(getal < 200) || !(getal > 200))
            {
                Console.WriteLine("200");
            }
            else
            {
                Console.WriteLine("geen 200");
            }

            //optie 9 MET BOOLEAN
            string antwoord = Console.ReadLine();
            bool check = Int32.TryParse(antwoord, out int x);
            if (check)
            {
                if (x == 200)
                {
                    Console.WriteLine("gelijk");
                }
                else
                {
                    Console.WriteLine("niet gelijk");
                }
            }
            else
            {
                Console.WriteLine("Geef een correct geheel getal in!");
            }

            //optie 10
            bool B = Int32.TryParse(antwoord, out x);
            if (!B)
            {
                Console.WriteLine("geen getal");
            }
            else
            {
                Console.WriteLine("wel een getal, nu enkel nog checken of 200 of niet");
            }


        }
    }
}