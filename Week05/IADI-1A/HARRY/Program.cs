using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("Harry", RegexOptions.IgnoreCase);
            string text = File.ReadAllText("Harry Potter and the Sorcerer.txt");
            string s = regex.Replace(text, "Anthony");
            Console.WriteLine(s);


            //last exercise of the day with CSV
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Slytherin"))
                {
                    int firstSemi = item.IndexOf(';');
                    string substring = item.Substring(firstSemi + 1);
                    int secondSemi = substring.IndexOf(';');
                    string name = substring.Substring(0,secondSemi);
                    Console.WriteLine(name);
                }
            }
        }
    }
}