using System;
using System.IO;

namespace LaatsteOefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Slytherin"))
                {
                    int eerstePuntKomma = item.IndexOf(';');
                    string deelVanDeZin = item.Substring(eerstePuntKomma + 1);
                    int tweedePuntKomma = deelVanDeZin.IndexOf(';');
                    string naam = deelVanDeZin.Substring(0,tweedePuntKomma);
                    Console.WriteLine(naam);
                }
            }

            Console.WriteLine($"\n-----------\n");

            //dit keer met arrays
            string[] lijnen = File.ReadAllLines("Characters.csv");
            foreach (string zin in lijnen)
            {
                string[] opgedeeld = zin.Split(";");
                if (opgedeeld[4] == "Gryffindor")
                {
                    Console.WriteLine(opgedeeld[1]);
                }
            }


            /*{"id; naam; ...", "1; Harry; ..."}
            {{"id", "naam", "..."}, {"1", "Harry", "..."}}*/
        
        }
    }
}