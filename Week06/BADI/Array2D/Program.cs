using System;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aanmaken van 2D arrays
            int[,] ints = new int[2,5];
            string[,] fruit = {{"lychee", "appel", "banaan"},
            {"banaan", "druif", "bosbes"},
            {"aardbei", "peer", "ananas"}};


            //aanpassen
            Console.WriteLine(fruit[2,2]);
            fruit[2,2] = "durian";
            Console.WriteLine(fruit[2,2]);

            //loopen
            Console.WriteLine(fruit.Length);
            Console.WriteLine($"rijen: {fruit.GetLength(0)}");
             Console.WriteLine($"kolommen: {fruit.GetLength(1)}");


             //int array vullen met gehele getallen

            Random r = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i,j] = r.Next(1, 101);
                    Console.Write(ints[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}