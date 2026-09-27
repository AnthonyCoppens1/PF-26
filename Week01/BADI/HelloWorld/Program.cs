using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            //Console.WriteLine("Dit is een test!!!");
            Console.Write("Geen idee");
            Console.Write("Nog wat meer tekst");*/

            //1 individuele regel commentaar
            /*
            Alles daartussen
            is commentaar
            op meerdere regels */

            Console.WriteLine("HET EINDE!");


            //Klein programma dat een persoon bij naam kan benoemen
            string naam; //declareren of declare
            naam = "Jean Louis Michel"; //initializeren
            naam = naam + " Lawson";


            //3 manieren
            //manier 1 - Concatenation
            Console.WriteLine("Hello " + naam + "!.Dit is allemaal tekst");

            //manier 2
            Console.WriteLine($"Hello {naam}! Nog wat extra tekst");

            //manier 3
            Console.WriteLine("Hello {0} en {1}", naam, naam);

            char a = 'z';
            char kleineLetter = 'b';

            double x = 3.2;


            //eigen input
            string achternaam = Console.ReadLine(); //leest wat je typt en opent een nieuwe lijn
            Console.WriteLine($"Hey {achternaam}");


            Console.WriteLine(7);
            Console.WriteLine(7.ToString());




        }
    }
}