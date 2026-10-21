using System;
using System.IO;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //READING FILES ALL ESSENTIALS AND MESSING ABOUT
            StreamReader inputStream = File.OpenText("Rapunzel.txt");
            string text = inputStream.ReadToEnd();
            inputStream.Close();
            Console.WriteLine(text);

            Console.WriteLine("\n---------------------------\n");

            inputStream = File.OpenText("Rapunzel.txt");
            while (!inputStream.EndOfStream)
            {
                string line = inputStream.ReadLine();
                Console.WriteLine($"--> {line}");
            }
            inputStream.Close();


            //char by char
            inputStream = File.OpenText("Rapunzel.txt");
            while (!inputStream.EndOfStream)
            {
                Console.Write($"+ { (char)inputStream.Read() }");
            }
            inputStream.Close();


            //foreach loop
            /*
            foreach (datatype name in WhatYouWantToLoopThrough)
            {
            }
            
            */
            Console.WriteLine("\n---------------------------\n");

            foreach (string sentence in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine($"^^{sentence}");
            }

            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write($"-- {c}");
            }
            Console.WriteLine();

            foreach (var c in "Anthony")
            {
                Console.Write($"-- {c}");
            }

        }
    }
}