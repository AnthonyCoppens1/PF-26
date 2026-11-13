using System;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating
            int[][] ints = new int[3][];
            ints[0] = new int [] {1,2,3,4};
            ints[1] = new int [] {5,6};
            ints[2] = new int [] {7, 8, 9};
            
            string[][] fruit = {new string[] {"apple", "avocado", "apricot"},
            new string[] {"banana", "berry", "blueberry"},
            new string[] {"coconut"},
            new string[] {"durian", "dragonfruit"}};

            double[][] DD = {new double[] {1.2, 5.8},
            new double[] {4.5, 7.9}};


            //getting values
            Console.WriteLine($"{fruit[2][0]}");
            Console.WriteLine($"{DD[1][0]}");
            DD[1][0] = -5.9;
            Console.WriteLine($"{DD[1][0]}");

            Console.WriteLine(fruit.Length); //all of the rows

            //looping
            for (int i = 0; i < fruit.Length; i++)
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write($"{fruit[i][j]} ");
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                foreach(var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            //not treated like 2D arrays, every row is the outer loop, every element of a row is the inner loop.

            //Exercise on jagged arrays
            //Anthony's football team
            //set up a jagged array that houses the players of the team
            //3 - 4 - 3 - 1 / 2 - 5 - 3 - 1 / 1 - 5 - 4 - 1

            //write the names evenly split with a space for every role: attacker, midfield, defender, goalie
            /*
            Attack:     Nathan Maria Joseph
            Midfield:   Kevin Julie Nadine Bert
            Defense:    John Anthony Sophia
            Goalie:     Enrique
            */

            string[][] team = new string[4][];
            for (int i = 0; i < team.Length; i++)
            {
                //add every row with the players:
                Console.WriteLine($"Enter the names of the players, evenly split with a space:");
                team[i] = Console.ReadLine().Split();
            }

            string[] roles = {"Attack", "Midfield", "Defense", "Goalie"};
            for (int i = 0; i < team.Length; i++)
            {
                string[] role = team[i];
                Console.Write($"{roles[i]}:  ");

                foreach (var player in role)
                {
                    Console.Write($"{player} ");
                }
                Console.WriteLine();
            }



        }
    }
}