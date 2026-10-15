using System;
using System.Diagnostics;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veelvouden van een gegeven nummer
            Console.Write($"geef me een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            //lastige versie, met extreem veel moeite
            Console.WriteLine($"{getal} * 1 = {getal * 1}");
            Console.WriteLine($"{getal} * 2 = {getal * 2}");
            Console.WriteLine($"{getal} * 3 = {getal * 3}");
            Console.WriteLine($"{getal} * 4 = {getal * 4}");
            Console.WriteLine($"{getal} * 5 = {getal * 5}");
            Console.WriteLine($"{getal} * 6 = {getal * 6}");

            //pak efficienter
            //eerst algemene syntax
            Console.WriteLine($"\nFOR LOOP i = 0 en i <= 10 ");
            for (int i = 0; i <= 10; i++) //i = i + 1
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }

            //let op, wat wordt aangemaakt in de loop, kan niet buiten de loop worden opgeroepen, als je iets aanmaakt buiten de loop
            //kan je er een aanpassing aan laten maken in de loop en het dan erbuiten opnieuw oproepen.


            Console.WriteLine($"\nFOR LOOP i = 1 en i <= 10 ");
            for (int i = 1; i <= 10; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine($"\nFOR LOOP i = 0 en i <= 10, stappen 2 ");
            for (int i = 0; i <= 10; i += 2) 
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }


            Console.WriteLine($"\nFOR LOOP i = 0 en i <= 10, stappen maal 2 ");
            //PAS OP, als je startpunt 0 is, heb je een infinite loop, want 0 * 2 blijft altijd 0
            for (int i = 1; i <= 10; i *= 2) 
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }

            //omgekeerde richting
            Console.WriteLine($"\nFOR LOOP i = 10 en i <= 10, stap van 1 ");
            for (int i = 10; i >= 0; i--) 
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }


            //print de volgende reeks uit: 3 6 9 12 15 18 ... 33
            Console.WriteLine($"\nSEQUENCE 1");
            for (int i = 3; i <= 33; i += 3)
            {
                Console.Write($"{i} ");
            }

            //reminder van week 2: 
            /*
            5 / 3 = 1
            5 % 3 = 2
            4 % 3 = 1
            3 % 3 = 0
            6 % 3 = 0
            7 % 3 = 1
            */

            Console.WriteLine($"\nSEQUENCE 2");
            for (int i = 1; i <= 33; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }


            //geneste loops
            Console.Write($"\n\n Geef x op: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\n\n Geef y op: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++) // x = 5
            {
                for (int j = 0; j < y; j++) // y = 5
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            /*
            i=0 j=0 / i=0 j=1 /i=0 j=2 / i=0 j=3 / i=0 j=4 
            i=1 j=0
            * * * * * 
            * * * * *
            * * * * *
            * * * * *
            * * * * *
            */

            Console.WriteLine($"\n tabel van J");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\n tabel van I");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }


            //loops van elkaar laten afhangen
            Console.WriteLine($"\nPYRAMID");
            /*
            *
            * *
            * * *
            * * * *

            i=1 j=0 / i=2 j=0 / i=2 j=1 / i=2 j=2
            */

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }


            /*
            1.          3.
            *           O O O *
            * *         O O * *
            * * *       O * * *
            * * * *     * * * *

            2.          4.
            * * * *     * * * *
            * * *       O * * *
            * *         O O * *
            *           O O O *
            
            bij 3 en 4 heb je 2 loops in de buitenste
            */

            Console.WriteLine($"#1");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"#2");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"#3");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write($"  ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"#4");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"  ");
                }
                for (int k = 4; k >= i; k--)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }


        }
    }
}