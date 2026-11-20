using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //korte recap van arrays voor we starten met lists
            //1D array --> vaste lengte

            int[] getalArray = new int[5];
            //{0,0,0,0,0}
            getalArray[0] = 5;
            getalArray[1] = 10;
            getalArray[2] = 15;
            getalArray[3] = 20;
            getalArray[4] = 25;

            
            //lists --> geen vaste lengte
            List<int> ints = new List<int>();
            ints.Add(5); //index 0
            ints.Add(10); //index 1
            ints.Add(15); //index 2
            ints.Add(20);
            ints.Add(25);
            ints.Add(30);

            //printen van de inhoud van beide
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write($"{ints[i]} ");
            }
            Console.WriteLine();

            /*loop gebruiken voor elementen toe te voegen aan de list
            for (int i = 0; i < 10; i++)
            {
                ints.Add(i + 5);
            }
            Console.WriteLine();

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write($"{ints[i]} ");
            }
            Console.WriteLine();*/

            // . Insert
            //toevoegen van bepaalde getallen of het gevraagde datatype in een bepaalde plek. 
            //rekening mee houden dat oude index een plaats opschuift.

            ints.Insert(2, 12);

            //ook mogelijk, zelfde index, ander getal
            ints.Insert(4, 21);
            ints.Insert(4, 22);


            //grote gehele toevoegen
            int[] getallen = {7,8,9};
            ints.AddRange(getallen);

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write($"{ints[i]} ");
            }
            Console.WriteLine();


            //grote gehelen op een specifieke plek
            ints.InsertRange(1, getallen);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            //elementen verwijderen
            //7 8 9 eruit
            ints.Remove(7); //eerste keer dat dit object wordt herkent, wordt het er uit gehaald.
            ints.Remove(8);
            ints.Remove(9);

            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            
            ints.RemoveRange(ints.Count-3, 3);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();



            ints.Add(5);
            ints.RemoveAt(0);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            //checken van RemoveAll
            ints.Add(10);
            Predicate<int> pre = delegate(int a){ return a % 2 == 0; };
            ints.RemoveAll(pre);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            //nog meer technieken om getallen of elementen toe te voegen aan een list
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);

            for (int i = 0; i < N.Count; i++)
            {
                Console.Write($"{N[i]} ");
            }
            Console.WriteLine();

            //starten bij 4, loopen tot en met 2 en telkens op index 1 invoegen
            /*for (int i = 4; i > 1; i--)
            {
                N.Insert(1, i);
            }*/

            //op de juiste plek invoegen en in de juiste volgorde
            for (int i = 2; i < 5; i++)
            {
                N.Insert(i-1, i);
            }

            for (int i = 0; i < N.Count; i++)
            {
                Console.Write($"{N[i]} ");
            }
            Console.WriteLine();


            //list van strings
            List<string> str = new List<string>{"een", "twee", "drie"};
            for (int i = 0; i < str.Count; i++)
            {
                Console.Write($"{str[i]} ");
            }
            Console.WriteLine();

            str.Add("vier");
            str.Add("vijf");
            str.Insert(0, "nul");

            str.Remove("twee");
            str.RemoveAt(4);
            for (int i = 0; i < str.Count; i++)
            {
                Console.Write($"{str[i]} ");
            }
            Console.WriteLine();


            //zoeken naar elementen in een string
            //zoeken naar een index
            int index = str.IndexOf("drie");
            Console.WriteLine(index);

            str.Add("een");
            for (int i = 0; i < str.Count; i++)
            {
                Console.Write($"{str[i]} ");
            }
            Console.WriteLine();

            int laatste = str.LastIndexOf("een");
            Console.WriteLine(laatste);

            str.Add("More");
            if (str.Contains("More"))
            {
                index = str.IndexOf("More");
                str.Insert(index, "Thomas");
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write($"{str[i]} ");
            }
            Console.WriteLine();



            //list naar array
            string[] strings = str.ToArray();

            //array naar list
            double[] doubles = {1.2, 3.5, 8.9};
            List<double> D = doubles.ToList();




            



        }
    }
}