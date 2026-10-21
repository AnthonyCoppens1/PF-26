using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reading through the file line by line
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Slytherin"))
                {
                    int first = item.IndexOf(";");
                    string substring = item.Substring(first + 1);
                    int second = substring.IndexOf(";");
                    Console.WriteLine(substring.Substring(0,second));
                }
            }

            Regex rx = new Regex(@"\d{4}");
            MatchCollection matches = rx.Matches(File.ReadAllText("Characters.csv"));
            foreach (Match item in matches)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}