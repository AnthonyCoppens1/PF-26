using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array of length 4
            string[] words = {"these", "are", "some", "words"};
            int[] numbers = new int[5];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;
            numbers[3] = 20;
            numbers[4] = 25;
            //numbers[5] = 30; Length is locked, so no point in doing this

            //lists --> no set length
            List<int> NumberList = new List<int>();
            NumberList.Add(5);
            NumberList.Add(10);
            NumberList.Add(15);
            NumberList.Add(20);
            NumberList.Add(25);

            Console.WriteLine(NumberList.Count);

            List<string> WordList = new List<string>{"This", "is", "a", "list", "of", "words"};


            //looping through a list
            for (int i = 0; i < NumberList.Count; i++)
            {
                Console.Write($"{NumberList[i] + 20} ");
            }
            Console.WriteLine();


            foreach (string word in WordList)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();



            //5 10 15 20 25
            //insert numbers into a specific spot
            NumberList.Insert(2, 12);
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            NumberList.Insert(4, 21);
            NumberList.Insert(4, 22);

            //5 10 12 15 22 21 20 25
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();



            //add multiple items
            int[] someNumbers = {7, 8, 9};
            NumberList.AddRange(someNumbers);

            //insert multiple numbers
            NumberList.InsertRange(1, someNumbers);
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            
            //removing elements
            NumberList.Remove(7);
            NumberList.Remove(8);
            NumberList.Remove(9);
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();



            NumberList.Add(5);
            NumberList.RemoveAt(0);
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            /*
            Predicate<int> pre = delegate(int a){ return a % 5 == 0; };
            NumberList.RemoveAll(pre);
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();*/

            NumberList.AddRange(someNumbers);

            while (NumberList.Contains(7))
            {
                NumberList.Remove(7);
            }
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();




            NumberList.RemoveRange(0, 3);
            NumberList.RemoveRange(NumberList.Count - 2, 2);
            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            //I want to make this into   1 2 3 4 5
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);

            //1 2 3 4 5
            /*for (int i = 2; i < 5; i++)
            {
                N.Insert(i - 1, i);
            }*/

            //1 2 3 4 5
            for (int i = 4; i > 1; i--)
            {
                N.Insert(1, i);
            }



            WordList = new List<string>{"one", "two", "three", "four"};
            WordList.Add("one");

            int lastIndex = WordList.LastIndexOf("one");
            Console.WriteLine(lastIndex);

            WordList.Add("More");
            if (WordList.Contains("More"))
            {
                WordList.Insert(WordList.IndexOf("More"), "Thomas");
            }

            string[] strings = WordList.ToArray();
            double[] doubles = {1.2, 5.8, -3.7};
            List<double> DD = doubles.ToList();

        }
    }
}