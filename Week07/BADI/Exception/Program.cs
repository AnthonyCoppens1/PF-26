using System;
using System.IO;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getal);

            Console.WriteLine($"Geef een aantal lijnen: ");
            int lijnen = Convert.ToInt32(Console.ReadLine());
            StreamReader stream = File.OpenText("english.txt");

            for (int i = 0; i < lijnen; i++)
            {
                Console.WriteLine($"--> {stream.ReadLine()}");
            }




            //oude manier van Exception handling
            Console.WriteLine($"Geef een aantal lijnen: ");
            string antwoord = Console.ReadLine();

            //Convert.ToInt32 / Double.Parse / (char) / Int32.TryParse(input, out output)

            if (Int32.TryParse(antwoord, out int nr))
            {
                try
                {
                    string[] file = File.ReadAllLines("english.txt"); //\n
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("File niet gevonden");
                }
                
            }
            else
            {
                Console.WriteLine($"Verkeerd getal");
            }







            
        }
    }
}