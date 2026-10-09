using System;

namespace OefeningenIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int geboortejaar = Convert.ToInt32(Console.ReadLine());
            int huidigJaar = DateTime.Now.Year;

            int leeftijd = huidigJaar - geboortejaar;
            if (leeftijd >= 16 && leeftijd < 18)
            {
                Console.WriteLine("Bier en wijn");
            }
            else if (leeftijd >= 18)
            {
                Console.WriteLine("Sterke drank");
            }
            else if (leeftijd < 16 && leeftijd >= 0)
            {
                Console.WriteLine("chocomelk of kidibul");
            }
            else
            {
                Console.WriteLine("Je bestaat niet, geef een correct jaar in!");
            }

            /* programmeer een love calculator
            Lezen 2 namen in en genereer een RANDOM liefdespercentage (double)
            Stel zelf een if-statement samen met een gepaste boodschap naargelang hun liefde

            Gebruik de klasse Random --> zoek naar een methode die een random double
            genereert tussen 0 en 1. 0.783264846
            */ 
            string naam1 = Console.ReadLine();
            string naam2 = Console.ReadLine();

            Random r = new Random();
            double percentage = r.NextDouble();
            percentage = percentage * 100;

            if (percentage > 90)
            {
                Console.WriteLine($"Goeie liefde, Walid approved! " +
                $"Jullie hebben een percentage van {percentage:F2}%");
                // .ToString("0.00")
            }
            else if (percentage > 50)
            {
                Console.WriteLine($"Ik zou overwegen naar een therapeut te gaan met " +
                $"een percentage van {percentage:F2}%");
                // .ToString("0.00")
            }
            else
            {
                Console.WriteLine($"Hopeloos met een percentage van {percentage:F2}%");
            }

        }
    }
}