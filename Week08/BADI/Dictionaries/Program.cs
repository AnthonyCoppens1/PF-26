using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> combo = new Dictionary<int, string>();
            combo.Add(8, "Hallo");
            combo.Add(3, "mijn");
            combo.Add(-2, "naam");
            combo.Add(5, "is");
            combo.Add(32, "Anthony");

            foreach (int key in combo.Keys)
            {
                Console.WriteLine(combo[key]);
            }

            foreach (string value in combo.Values)
            {
                Console.WriteLine(value);
            }

            foreach (var paar in combo)
            {
                Console.WriteLine(combo[paar.Key]);
                Console.WriteLine(paar.Value);
            }

            Console.WriteLine("-----------------");
            for (int i = 0; i < combo.Count; i++)
            {
                Console.WriteLine(combo.ElementAt(i));
            }


            combo[32] = "Jean";
            Console.WriteLine(combo[32]);

            
            //verwijderen uit dictionaries
            combo.Remove(-2);
            combo.Remove(32, out string naam);
            Console.WriteLine(naam + " Achternaam");

            if (combo.ContainsKey(8))
            {
                Console.WriteLine(combo[8]);
            }
            //combo.ContainsValue("mijn");


            Dictionary<string, double> doubles = 
            new Dictionary<string,double>{{"b", 2.1}, {"a", 9.2}, {"c", -5.8}};


            string[] lijnen = File.ReadAllLines("woorden.txt");
            Dictionary<char, int> teller = new Dictionary<char, int>();

            foreach (char letter in lijnen[10]) //lepel
            {
                if (!teller.ContainsKey(letter))
                {
                    teller[letter] = 1;
                }
                else
                {
                    teller[letter]++;
                }
            }
            int som = 0;
            foreach (var value in teller.Values)
            {
                som += value;
            }
            if (som == lijnen[10].Length)
            {
                Console.WriteLine("Heterogram");
            }


        }
    }
}