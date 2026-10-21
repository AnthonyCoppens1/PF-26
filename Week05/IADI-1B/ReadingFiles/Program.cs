using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read through a file and either print out stuff or add things and then close
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();

            Console.WriteLine($"1 {text}");

            Console.WriteLine("\n--------------------------------------------------------\n");

            //couple of ways of dealing with files
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                /*string line = input.ReadLine();
                Console.WriteLine($"+++ {line}");*/
                //other option

                Console.WriteLine($"+++ {input.ReadLine()}");
            }
            input.Close();


            //read through the file char by char
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write($"-{(char)input.Read()}");
            }
            input.Close();

            //foreach through the text
            /*
            foreach (datatype name in WhatYouWantToLoopThrough)
            {
            
            }
            */


            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine($"--> {item}");
            }


            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write($"+{c}");
            }

            Console.WriteLine("\n--------------------------------------------------------\n");

            //opening a file and reading content
            //option 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();
            */

            //option 2
            string textFromFile = File.ReadAllText("Rapunzel.txt");

            //count characters
            Console.WriteLine($"# of chars: {textFromFile.Length}");


            //count lines
            Console.WriteLine($"# of lines: {File.ReadAllLines("Rapunzel.txt").Length}");
            

            //count lines in a different way
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();

            Console.WriteLine($"# of lines again: {lines}");


            //count the A's and a's in file
            //while

            int countA = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (c == 'a' || c == 'A')
                {
                    countA++;
                }

                //if ("aA".Contains(c)) --> another variant that works
            }
            sr.Close();
            Console.WriteLine($"# of A and a: {countA}");


            //foreach
            countA = 0;
            foreach (char item in textFromFile.ToLower())
            {
                if (item == 'a')
                {
                    countA++;
                }
            }
            Console.WriteLine($"# of A and a: {countA}");



            //for
            countA = 0;
            for (int i = 0; i < textFromFile.Length; i++)
            {
                if (textFromFile[i] == 65 || textFromFile[i] == 97)
                {
                    countA++;
                }
            }
            Console.WriteLine($"# of A and a: {countA}");


            //counting words, but in a VERY weird way (using space)
            int countingWords = 0;
            foreach(char c in text)
            {
                if (c == ' ')
                {
                    countingWords++;
                }
            }
            Console.WriteLine($"# of words: {countingWords}");


            //counting rapunzels
            string word = "";
            int countRapunzels = 0;

            foreach (char c in textFromFile.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        countRapunzels++;
                    }
                    word = "";
                }
            }

            Console.WriteLine($"# of rapunzels: {countRapunzels}");


            //REGEX
            Regex regex = new Regex("rapunzel",RegexOptions.IgnoreCase);
            //Regex rx = new Regex("RAPUNZEL|rapunzel|Rapunzel"); also correct

            MatchCollection matches = regex.Matches(textFromFile);
            Console.WriteLine($"# of rapunzels: {matches.Count}");

            string s = regex.Replace(text, "Anthony");
            Console.WriteLine(s);
        }
    }
}