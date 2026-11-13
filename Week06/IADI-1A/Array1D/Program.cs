using System;
using System.IO;

namespace Array1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D arrays
            //creating
            int[] intArray = new int[5]; //all values are 0
            Console.WriteLine(intArray);
            int x = 10;
            Console.WriteLine(x);

            foreach (int item in intArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            string[] stringies = new string[4]; //all values are ""
            bool[] bools = {true, true, false, false, false, true, true};


            double[] doubles = {1.5, 9, 10.0, -6, 12, 5.6};
            Console.WriteLine(doubles.Length);
            Console.WriteLine(doubles[0]); //very first item in doubles
            Console.WriteLine(doubles[doubles.Length-1]); //last number
            Console.WriteLine(doubles[5]);//last number
            Console.WriteLine(doubles[^1]);//last number 

            stringies[0] = "Flora";
            stringies[1] = "Techna";
            stringies[3] = "Musa";
            stringies[2] = "Stella";
            //stringies[4] = "Anthonya"; --> won't work,; no room for this one! INDEX OUT OF RANGE

            foreach (var item in stringies)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();



            Console.WriteLine(doubles[doubles.Length-1]);
            doubles[5] = 1.0;
            Console.WriteLine(doubles[doubles.Length-1]); 


            foreach (var item in doubles)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //couple other ways of looping
            //for

            for (int i = doubles.Length-1; i >= 0; i--)
            {
                Console.Write($"{doubles[i]} ");
            }
            Console.WriteLine();

            //while
            int index = 0;
            while (index < doubles.Length)
            {
                Console.Write($"{doubles[index]} ");
                index++;
            }
            Console.WriteLine();


            doubles = new double[]{2, 7.8, -3, 15.1};
            foreach (var item in doubles)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();



            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 4;
                /*Console.Write($"Enter a number: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());*/
            }

            foreach (var item in intArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();



            Console.WriteLine($"Give me some of your favourite animals: ");
            string answer = Console.ReadLine();
            //unicorn capibara sealion panda koala lion tiger 
            string[] animals = {"unicorn", "capibara", "sealion", "panda", "koala", "lion", "tiger"}; //answer.Split();
            foreach (var item in animals)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine($"{animals[2]} and {animals[5]} are best friends <3");

            string[] lines = File.ReadAllLines("Rapunzel.txt");
            foreach (var item in lines)
            {
                Console.WriteLine($"--> {item} ");
            }
            Console.WriteLine();


            string text = File.ReadAllText("Rapunzel.txt");
            string[] rapunzelSplit = text.Split("Rapunzel");
            foreach (var item in rapunzelSplit)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();



            //converting
            Console.WriteLine($"Enter a bunch of numbers split by a space: ");
            answer =  "12 5 8";
            string[] numbers = answer.Split();
            int[] convertedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                convertedNumbers[i] = Convert.ToInt32(numbers[i]);
            }

            foreach (var item in convertedNumbers)
            {
                Console.WriteLine($"{item + 20} ");
            }
            Console.WriteLine();


            //easy way but blocked for 1-2 weeks of exercises
            convertedNumbers = Array.ConvertAll(numbers, Convert.ToInt32);

            int[] array = {5, 2, 1, 3, 4};
            Console.WriteLine($"sum: {array.Sum()}");
            Console.WriteLine($"min: {array.Min()}");
            Console.WriteLine($"max: {array.Max()}");
            Console.WriteLine($"average: {array.Average()}");
            Array.Sort(array);
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //manual labor if we lost braincells from drinking or drugs or something else
            array = new int[] {5, 1, 3, 4, 2};
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"sum {sum}");
            Console.WriteLine($"average {sum/array.Length}");



            array = new int[] {5, 1, 3, 4, 2};
            int lowest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < lowest)
                {
                    lowest = array[i];
                }
            }

            Console.WriteLine($"min: {lowest}");

            //one of the sorting algorithms
            //bubble sort
            //https://en.wikipedia.org/wiki/Bubble_sort 

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();



        }
    }
}