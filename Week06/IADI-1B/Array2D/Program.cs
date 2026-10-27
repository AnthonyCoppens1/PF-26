using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D arrays
            //creating
            int[,] ints = new int[4,5];
            string[,] strings = {{"banana", "passionfruit", "fig", "apple"}, {"lime", "citron", "orange", "durian"}, 
            {"peach", "pineapple", "mango", "kiwi"}};

            
            //getting values
            Console.WriteLine(strings[0,0]);
            Console.WriteLine(strings[2,1]);

            strings[2,1] = "pear";
            Console.WriteLine(strings[2,1]);

            //looping
            Console.WriteLine(strings.Length); //9
            Console.WriteLine($"# of rows: {strings.GetLength(0)}");
            Console.WriteLine($"# of cols: {strings.GetLength(1)}");

            for (int i = 0; i < strings.GetLength(0); i++)
            {
                for (int j = 0; j < strings.GetLength(1); j++)
                {
                    Console.Write($"{strings[i,j]} ");
                }
                Console.WriteLine();
            }

            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }


            //filling an array with random numbers
            ints = new int[4,5];
            Random rd = new Random();
            // rd.Next(min, max)

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i,j] = rd.Next(1, 11);
                    Console.Write(ints[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}