using System;
using System.Collections.Generic;
using System.IO;

namespace recapEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Read through the file and pick a specific sentence.
            Split the sentence into a string array
            Find a way to count the letters in a word to be 
            able to find each heterogram.
            --> use a dictionary to count this.

            A heterogram is a word in which each unique letter 
            only appears 1 time.
            E.g. steal --> heterogram
            thought --> not a heterogram because the t and h 
            appear twice.
            */

            string[] sentences = File.ReadAllLines("file.txt");
            Console.Write($"What sentence would you like? ");
            int index = Convert.ToInt32(Console.ReadLine());

            string[] splitWords = sentences[index-1].Split();
            //{{The}, {early}, {bird}, {gets}, {the}, {worm}}

            List<string> heterograms = new List<string>();

            for(int i = 0; i < splitWords.Length; i++) //this loop goes word by word
            {
                Dictionary<char, int> letterCounter = new Dictionary<char,int>();

                foreach(char letter in splitWords[i]) //this loop goes through each char in the SELECTED WORD
                {
                    if (!letterCounter.ContainsKey(letter))
                    {
                        letterCounter[letter] = 1; //{{'t', 1}} {{'t', 1}, {'h', 1}} {{'t', 1}, {'h', 1}, {'e', 1}}
                    }
                    else
                    {
                        letterCounter[letter]++;
                    }
                }


                bool moreThanOne = false;
                foreach (var value in letterCounter.Values)
                {
                    if (value > 1)
                    {
                        moreThanOne = true;
                    }
                }

                if (moreThanOne == false)
                {
                    heterograms.Add(splitWords[i]);
                }
            }
            
        }
    }
}