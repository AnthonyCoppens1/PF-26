using System;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            while (voorwaarde)
            {
                code die moet worden uitgevoerd
            }
            */

            Console.Write($"START! druk op y om verder te gaan, iets anders om te stoppen: ");
            string antwoord = Console.ReadLine();

            while(antwoord == "y")
            {
                Console.Write("druk y om verder te gaan, iets anders om te stoppen: ");
                antwoord = Console.ReadLine();
            }


            //maak een wachtwoord checker en check of het ww klopt, indien 3 keer fout, geen toegang.
            Console.Write($"Geef je wachtwoord in: ");
            string wachtwoord = Console.ReadLine();
            int kansen = 3;

            while (wachtwoord != "BADIvideoLES")
            {
                kansen--;
                if (kansen > 0)
                {
                    Console.WriteLine($"Wachtwoord was fout, probeer opnieuw: ");
                    wachtwoord = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            if (kansen > 0)
            {
                Console.WriteLine($"Je bent aangemeld! Je had nog {kansen} kansen over");
            }
            else
            {
                Console.WriteLine($"GEEN TOEGANG, je had {kansen} kansen over");
            }


            //gambling game!
            //hoger lager spelen tussen 2 gegeven waarden

            Random randomGetal = new Random();
            int getal = randomGetal.Next(1,3);

            Console.Write($"Probeer het getal te raden: ");
            int keuze = Convert.ToInt32(Console.ReadLine());
            int gokKansen = 1;

            while (keuze != getal)
            {
                gokKansen++;
                if (keuze < getal)
                {
                    Console.WriteLine("HOGER");
                    Console.Write($"Probeer het getal te raden: ");
                    keuze = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("LAGER");
                    Console.Write($"Probeer het getal te raden: ");
                    keuze = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"Goed gedaan, het getal was {getal} en je hebt het geraden in {gokKansen} pogingen");
            

            //reeks van 3 9 27 ...
            Console.WriteLine($"REEKS 1");
            int i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write($"{i} ");
                i *= 3;
            }

            Console.WriteLine($"\nREEKS 2");
            i = 3;
            while (i < Int16.MaxValue)
            {
                i *= 3;
                Console.Write($"{i} ");
            }


            Console.WriteLine($"\nREEKS 3");
            i = 40000;
            while (i < Int16.MaxValue)
            {
                i *= 3;
                Console.Write($"{i} ");
            }

            //NIEUWE REEKS EN NIEUWE THEORIE
            Console.WriteLine($"\nREEKS 4");
            i = 40000;
            do
            {
                Console.Write($"{i} ");
                i *= 3;
            }
            while (i < Int16.MaxValue);
        

            /*MAGICAL NUMBERS
            27 --> 2² + 7² = 4 49 --> 53
            53 --> 5² + 3² = 25 + 9 --> 34
            34 --> 3² + 4² = 9 + 16 = 25
            BLIJFT DOORGAAN tot getal < 10

            while (getal >= 10)

            137 --> 
            137 / 100 = 1
            137 % 100 --> 37 / 10 = 3
            7 / 1 = 7
            
            nog een mogelijkheid:
            int --> 137 --> string S: "137" --> de lengte van een string --> .Length
            S[0] = '1'
            S[1] = '3'

            Convert.ToInt32(S[0].ToString())
            Math.Pow(getal, 2)

            */
        }
    }
}