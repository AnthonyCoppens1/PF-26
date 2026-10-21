using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tech number 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //tech number 2
            string text = File.ReadAllText("Rapunzel.txt");

            //another example of going through a file
            // string[] lines = File.ReadAllLines("Rapunzel.txt");

            Console.WriteLine($"# of chars: {text.Length}");
            Console.WriteLine($"# of lines: {File.ReadAllLines("Rapunzel.txt").Length}");

            //another way of counting lines
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();
            Console.WriteLine($"# of lines again is: {lines}");


            //counting R and r
            //while
            int countR = 0;
            sr = File.OpenText("Rapunzel.txt");

            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (c == 'R' | c == 'r')
                {
                    countR++;
                }

                //if ("rR".Contains(c)){}
            }

            sr.Close();
            Console.WriteLine($"number of R and r: {countR}");


            //foreach
            countR = 0;
            foreach (char c in text.ToLower())
            {
                if (c == 'r')
                {
                    countR++;
                }
            }
            Console.WriteLine($"number of R and r: {countR}");


            //for 
            countR = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 82 | text[i] == 114)
                {
                    countR++;
                }
            }
            Console.WriteLine($"number of R and r: {countR}");
         
            

            //counting words in a file
            int counter = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"number of words: {counter}");



            //counting rapunzels and maybe words again if we feel like it
            string word = "";
            int countingRapunzels = 0;

            foreach (char c in text.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        countingRapunzels++;
                    }
                    word = "";
                }
            }
            Console.WriteLine($"# of rapunzels: {countingRapunzels}");


            //regex and way easier
            Regex rx = new Regex("rapunzel", RegexOptions.IgnoreCase);
            Regex r = new Regex("RAPUNZEL|rapunzel|Rapunzel");
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine($"Number of rapunzels again: {matches.Count}");
            

        }
    }
}