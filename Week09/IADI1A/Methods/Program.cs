using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Addition(5, 10);
            int sum = AdditionAndReturn(10, 20) + 50;
            Console.WriteLine(sum);

            int[] numbers = {5,4,3,2,1};
            RUN(numbers); //print, then sort, then print

            int[] numbers2 = {9, 1, 2, 8, 5, 6, 3};
            RUN(numbers2);

            //I want to be able to write Fill(size)
            int[] array = Fill(20);
            RUN(array);

            array = Fill();
            RUN(array);


            string[] words = {"these", "are", "some", "words"};
            Print(words);

            double[] D = { 7.9, 1.2, 5.8};
            RUN(D);
        }

        static void RUN(double[] N)
        {
            Print(N);
            Array.Sort(N);
            Print(N);
        }

        static void RUN(int[] N)
        {
            Print(N);
            Array.Sort(N);
            Print(N);
        }

        static int[] Fill(int size = 10)
        {
            //I want to be able to fill an integer array with random numbers
            int[] array = new int[size];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0,101);
            }
            return array;
            //Array.Sort(array); --> dead code, does nothing
        } 

        static void Print(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int AdditionAndReturn(int number1, int number2)
        {
            return number1 + number2;
        }

        static void Addition(int firstNumber, int secondNumber)
        {
            int addition = firstNumber + secondNumber;
            Console.WriteLine(addition);
        }


        static void HelloWorld()
        {
            Console.WriteLine($"Hello to everyone in the world!");
        }
    }
}