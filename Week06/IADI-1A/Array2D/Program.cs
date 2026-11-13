using System;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D
            //creating
            int[,] ints = new int[4,5];
            string[,] fruits = {{"Pineapple", "watermelon", "kiwi", "apple"},
            {"pear", "banana", "durian", "citron"}, 
            {"lime", "strawberry", "blueberry", "orange"}};


            //getting values
            Console.WriteLine($"first item of fruit: {fruits[0,0]}");
            Console.WriteLine($"last item of fruit: {fruits[2,3]}");

            fruits[2,3] = "shoe";
            Console.WriteLine($"last item of fruit: {fruits[2,3]}");

            //be careful, .Length will show something different
            Console.WriteLine($"{fruits.Length}");
            Console.WriteLine($"{fruits.GetLength(0)}");
            Console.WriteLine($"{fruits.GetLength(1)}");

            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i,j] = rd.Next(1, 101);
                    Console.Write($"{ints[i,j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}