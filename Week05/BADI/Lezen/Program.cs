using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader lezen = File.OpenText("Harry Potter and the Sorcerer.txt");
            string inhoud = lezen.ReadToEnd();
            lezen.Close();
            Console.WriteLine(inhoud);


            lezen = File.OpenText("Harry Potter and the Sorcerer.txt");
            while (!lezen.EndOfStream)
            {
                string lijn = lezen.ReadLine();
                Console.WriteLine($"ààà {lijn}");
            }
            lezen.Close();


            lezen = File.OpenText("Harry Potter and the Sorcerer.txt");
            while (!lezen.EndOfStream)
            {
                char letter = (char)lezen.Read();
                Console.Write($"+ {letter}");
            }
            lezen.Close();


            //nieuwe techniek om te loopen
            foreach (char letter in inhoud)
            {
                Console.Write($"--{letter}");
            }


            foreach (string lijn in File.ReadLines("Harry Potter and the Sorcerer.txt"))
            {
                Console.WriteLine($"--{lijn}");
            }
            
        }
    }
}