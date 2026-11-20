using System;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D arrays --> laatste oefening
            /*
            rapport maken
            vraag aan de gebruiker hoeveel studenten er zijn
            vraag aan de gebruiker hoeveel testen er werden gegeven tijdens het afgelopen semester
            maak een systeem in een 2D array dat de punten kan opslaan voor alle studenten
            Zorg ervoor dat je achteraf een gemiddelde kan berekenen per student en per test

            buitenste rijen is een test per keer en iedere index is een student
            */
            

            /*Console.Write($"Geef een aantal studenten: "); //6
            int studenten = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Geef een aantal testen: "); //3
            int testen = Convert.ToInt32(Console.ReadLine());

            int[,] rapport = new int[testen, studenten];
            
            for(int i = 0; i < testen; i++)
            {
                for(int j = 0; j < studenten; j++)
                {
                    Console.Write($"Geef het resultaat van test {i + 1} van student {j + 1}: ");
                    rapport[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for(int i = 0; i < testen; i++)
            {
                Console.WriteLine($"test {i + 1}");

                for(int j = 0; j < studenten; j++)
                {
                    Console.Write($"{rapport[i,j]} ");
                }
                Console.WriteLine();
            }

            //gemiddelde per test
            for (int i = 0; i < testen; i++)
            {
                int som = 0;
                for (int j = 0; j < studenten; j++)
                {
                    som += rapport[i,j];
                }
                Console.WriteLine($"gemiddelde voor test {i + 1} is {som/studenten}");
            }

            //gemiddelde per student
            for (int i = 0; i < studenten; i++)
            {
                int som = 0;
                for (int j = 0; j < testen; j++)
                {
                    som += rapport[j, i];
                }
                Console.WriteLine($"gemiddelde voor student {i + 1} is {som/testen}");
            }
            
            

            string [,] stringTekst = {{"test","met","woorden"}, {"en", "nog", "meer"}};
            foreach (string woord in stringTekst)
            {
                foreach (char c in woord)
                {
                    Console.Write($"++{c} ");
                }
                Console.WriteLine();
            }*/



            //aanmaken
            int[][] getallen = new int[3][];
            getallen[0] = new int[] {1, 2, 3, 4};
            getallen[1] = new int[] {5};
            getallen[2] = new int[] {6, 7, 8};

            string[][] fruit = {new string[] {"appel", "banaan", "kiwi", "appelsien"},
            new string[] {"peer"},
            new string[] {"durian", "mango"}};

            double[][] D = {new double[]{1.2, 3.4},
            new double[]{6.1, 8.9}};

            //waarden aanpassen
            Console.WriteLine(D[1][1]);
            D[1][1] = 3.2;
            Console.WriteLine(D[1][1]);

            //loopen
            for (int i = 0; i < fruit.Length; i++)
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write($"{fruit[i][j]} ");
                }
                Console.WriteLine();
            }

            foreach (var item in getallen)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }


            /*mini football manager
            Maak een jagged array aan die alles kan behuizen
            Lees de namen van spelers in per categorie --> aanval, middenveld, verdedigers
            Sla de namen op in een jagged array en zorg ervoor dat je er door kan lopen
            3 - 4 - 3
            "Wallid Victor Ryan"
            "Erik Yannis Eloise Sofie"
            "Anthony Elke Collin"
            */


            string[][] team = new string[3][];

            for (int i = 0; i < team.Length; i++)
            {
                Console.WriteLine($"Geef de spelers:");
                team[i] = Console.ReadLine().Split();
            }

            foreach (var rij in team)
            {
                foreach (var speler in rij)
                {
                    Console.Write($"{speler} ");
                }
                Console.WriteLine();
            }



        }
    }
}