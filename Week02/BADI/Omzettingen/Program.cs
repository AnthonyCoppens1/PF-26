using System;

namespace Omzettingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string antwoord = Console.ReadLine();
            byte B = Convert.ToByte(antwoord);
            Console.WriteLine(B);

            short S = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(S + " is het getal");

            //reminder voor impliciete en expliciete omzetting / conversion
            Console.WriteLine(5); // impliciet
            Console.WriteLine(5.ToString()); // expliciet

            Console.Write($"Geef een character mee: ");
            antwoord = Console.ReadLine();
            char c = Convert.ToChar(antwoord);

            Console.WriteLine(c);

            Console.WriteLine((int)c);

            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x + 10);

            string naam = "Anthony";
            //int getalVanNaam = (int)naam; --> onmogelijk
            //int getal = (int)"78"; --> ook onmogelijk

            int getal = (int)78.92456;
            Console.WriteLine(getal);



            //totaal anders
            naam = "Victor";
            //eerste letter zoeken op 2 manieren
            //manier 1
            char eersteLetter = naam[0];
            Console.WriteLine(eersteLetter);

            //manier 2
            eersteLetter = naam.ElementAt(0);
            Console.WriteLine(eersteLetter);

            char laatsteChar = naam[naam.Length - 1];
            Console.WriteLine($"De laatste letter van {naam} is {laatsteChar}");



        }
    }
}