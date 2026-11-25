using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Read the file that contains a bunch of sentences.
            Grab a specific sentence and check however many words of a given sentence are heterograms.
            Write down all of these words.
            */

            string[] sentences = File.ReadAllLines("file.txt");
            string[] words = sentences[2].Split();

            List<string> heterograms = new List<string>();

            //{The, cold, outside, is, cold, if, it, is, freezing}
            for (int i = 0; i < words.Length; i++)
            {
                Dictionary<char, int> letterCounter = new Dictionary<char, int>();
                foreach (char c in words[i])
                {
                    if (!letterCounter.ContainsKey(c))
                    {
                        letterCounter[c] = 1;
                    }
                    else
                    {
                        letterCounter[c]++;
                    }
                }

                bool morethanOne = false;
                foreach(int value in letterCounter.Values)
                {
                    if (value > 1)
                    {
                        morethanOne = true;
                        break;
                    }
                }

                if (morethanOne == false)
                {
                    heterograms.Add(words[i]);
                }
            }

            foreach (string word in heterograms)
            {
                Console.WriteLine(word);
            }
            //freezing
            
            //{{'f', 1}, {'r', 1}, {'e', 2},{'z', 1}, {'i', 1}, {'n', 1}, {'g', 1}}
            //{{'T', 1}, {'h', 1}, {'e', 1}}

            //{{"Names", ["Rohan", "Harkirat", "Anthony", "Alex"]}, {"Ages", [19, 20, 31, 20]} }


            


        }
    }
}