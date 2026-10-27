using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating arrays
            int[] intArray = new int[10]; 
            Console.WriteLine(intArray);

            /*int i = 10;
            Console.WriteLine(i);*/

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"{intArray[i]} ");
            }
            Console.WriteLine();

            string[] strings = new string[4]; //all values are ""

            double[] doubles = {15.1, 10.0, 8.2, -5.1, -6, 12};
            Console.WriteLine(doubles.Length);

            Console.WriteLine($"Last element in doubles: {doubles[5]}");
            Console.WriteLine($"Last element in doubles: {doubles[doubles.Length-1]}");
            Console.WriteLine($"Last element in doubles: {doubles[^1]}");


            //assigning values
            strings[0] = "Dean";
            strings[1] = "Tom";
            strings[2] = "Jessica";
            strings[3] = "Maria";
            //strings[4] = "New girl"; --> gives an error, spot does not exist

            foreach (string s in strings)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();

            //changing values
            Console.WriteLine($"Last element in doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Last element in doubles: {doubles[^1]}");



            //looping through the array (above here is foreach and a for loop)
            //while

            int count = 0;
            while (count < doubles.Length)
            {
                Console.Write($"{doubles[count]} ");
                count++;
            }
            Console.WriteLine();

            doubles = new double[]{1, 3, 2, 5.2, 9.0, 18.1, 7, 2, 4, 1};
            foreach (var item in doubles)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //filling an empty array
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 4;
                /*Console.WriteLine($"Pick a number: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());*/
            }

            foreach (var item in intArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            Console.WriteLine($"Djago, pick your favourite animals: ");
            string answer = "tiger hyena puma dog cat lizard capibara crocodile hippopotamus";
            //"tiger hyena puma dog cat lizard capibara crocodile hippopotamus"
            string[] animals = answer.Split();

            foreach (var item in animals)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{animals[5]} and {animals[8]} are best friends <3");

            Console.WriteLine($"type more animals");
            answer = Console.ReadLine();
            animals = answer.Split(";");

            foreach (var item in animals)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();




            //converting an array
            Console.WriteLine($"Enter numbers, split with a space: ");
            answer = "8 7 -1 5 6 9 12 -3 0";
            string[] str = answer.Split();
            int[] ints = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                ints[i] = Convert.ToInt32(str[i]);
            }

            foreach (var item in ints)
            {
                Console.Write($"{item + 12} ");
            }
            Console.WriteLine();

            //an alternative way of converting a whole array
            ints = Array.ConvertAll(str, Convert.ToInt32);


            //build in methods to help you work with arrays
            //easy ways
            int[] array = {1, 8, -3, 6, 9, 2, 3, -4, 5};
            Console.WriteLine($"sum: {array.Sum()}");
            Console.WriteLine($"min: {array.Min()}");
            Console.WriteLine($"max: {array.Max()}");
            Console.WriteLine($"Average: {array.Average()}");

            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //algorithmic ways
            //create the sum and average
            array = new int[]{1, 8, -3, 6, 9, 2, 3, -4, 5};
            
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"average: {sum / array.Length}");


            //minimum
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"min: {min}");

            array = new int[]{1, 8, -3, 6, 9, 2, 3, -4, 5};
            //sorting according to an algoritm --> instead of doing Array.Sort(array)
            //we now sort with loops. https://nl.wikipedia.org/wiki/Bubblesort
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