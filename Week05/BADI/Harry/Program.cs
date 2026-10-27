using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText("Harry Potter and the Sorcerer.txt");
            string tekstje = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine(tekstje.Length);

            //lijnen tellen
            Console.WriteLine($"# lijnen: {File.ReadAllLines("Harry Potter and the Sorcerer.txt").Length}");

            StreamReader stroom = File.OpenText("Harry Potter and the Sorcerer.txt");
            int lijnen = 0;

            while (!stroom.EndOfStream)
            {
                stroom.ReadLine();
                lijnen++;
            }
            stroom.Close();
            Console.WriteLine($"aantal lijnen: {lijnen}");


            //tel de hoeveelheid ? in het bestand
            //while, for, foreach

            //while
            int vraagtekens = 0;
            stroom = File.OpenText("Harry Potter and the Sorcerer.txt");

            while (!stroom.EndOfStream)
            {
                char symbool = Convert.ToChar(stroom.Read());
                if (symbool == '?')
                {
                    vraagtekens++;
                }
            }
            Console.WriteLine($"hoeveelheid ?: {vraagtekens}");


            //for
            int teller = 0;
            for(int i = 0; i < tekstje.Length; i++)
            {
                if (tekstje[i] == 63)
                {
                    teller++;
                }
            }
            Console.WriteLine($"hoeveelheid ?: {teller}");


            //foreach
            teller = 0;
            foreach(char c in tekstje)
            {
                if ("?".Contains(c)) //"aeiou".Contains(c) 
                {
                    teller++;
                }
            }
            Console.WriteLine($"hoeveelheid ?: {teller}");



            //aantal woorden tellen --> iets dommere manier met spaties tracken
            int tellerWoorden = 0;

            foreach(char c in tekstje)
            {
                if (c == ' ')
                {
                    tellerWoorden++;
                }
            }
            Console.WriteLine($"AANTAL WOORDEN: {tellerWoorden}");


            //tweede manier. --> harry zoeken?
            string woord = "";
            int woordenTeller = 0;
            foreach (char c in tekstje.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn-'".Contains(c))
                {
                    woord += c;
                }
                else
                {
                    if (woord == "harry")
                    {
                        woordenTeller++;
                    }
                    woord = "";
                }
                
            }

            Console.WriteLine($"Aantal woorden: {woordenTeller}");
        }
    }
}