using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings are linked to numbers
            Dictionary<int, string> strings = new Dictionary<int, string>();
            strings.Add(8, "Hello");
            strings.Add(3, "my");
            strings.Add(-5, "name");
            strings.Add(78, "is");
            strings.Add(13, "Anthony");
            strings.Add(66, "Coppens");

            //loop through them
            foreach(var element in strings)
            {
                Console.WriteLine(element);
            }

            //looping through the keys
            foreach(int key in strings.Keys)
            {
                Console.WriteLine(key);
            }

            //going through values
            foreach(string value in strings.Values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            foreach(var item in strings)
            {
                Console.WriteLine($"{item.Key} has a value of {item.Value}");
            }



            //change something?
            strings[66] = "Joshua";

            //add something
            strings[88] = "NOT";

            foreach(var element in strings)
            {
                Console.WriteLine(element);
            }


            //removing elements
            strings.Remove(88);
            strings.Remove(66);
            strings.Remove(13, out string Name);


            //check if something is inside a dictionary
            if (strings.ContainsKey(3))
            {
                Console.WriteLine(strings[3]);
            }



            //other combinations
            Dictionary<string, string> wordsAndLetters = new Dictionary<string, string>();
            wordsAndLetters.Add("word", "a");
            wordsAndLetters.Add("door", "z");
            wordsAndLetters.Add("chair", "c");
            wordsAndLetters.Add("xylophone", "x");


            Dictionary<double, string> doubles = new Dictionary<double, string>{{3.1, "three"}, {-5.8, "five"}};

            string word = "anthony";
            Dictionary<char, int> countLetters = new Dictionary<char, int>();

            //{{'a', 1}, {'n', 2}, {'t', 1}, {'h', 1}, {'o', 1}, {'y', 1}}
            foreach(char letter in word)
            {
                if (!countLetters.ContainsKey(letter))
                {
                    countLetters[letter] = 1;
                }
                else
                {
                    countLetters[letter]++;
                }
            }
            
        }
    }
}