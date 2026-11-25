using System;
using System.Collections.Generic;

namespace StudentDatabank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //studentendatabank
            /*
            Maak een databank applicatie met 3 lists: 1 list voor alle namen, 1 list voor alle leeftijd en 1 voor
            alle geboortedatums
            ZOLANG DE GEBRUIKER NIET STOP ZEGT: VRAAG WAT DIE WIL DOEN?
            Zorg ervoor dat je er door kan loopen met een while en check wat de gebruiker wil doen?
            Opties: Add / ADJUST / DELETE

            ADD:
            Voeg dan de naam, leeftijd en geboortedatum toe aan de list als nietwe entry --> nieuwe index en lengte
            groeit.

            ADJUST:
            Vraag de gebruiker de naam van de persoon en wijzig dan de gegevens die je wil

            DELETE:
            Vraag de gebruiker de naam van de persoon waarvan je alles wil verwijderen.

            Als de gebruiker het overzicht opvraagt of het loopen doorbreekt --> toon alle studenten.
            OVERZICHT:
            Anthony     - 31 -      31/07/1995
            Erik        - 18 -      11/09/2008


            
            */
            //ADD --> toevoegen: Naam (string), leeftijd (int), geboortedatum(DateTime)
            //ADJUST --> wijzigen van gegevens
            //DELETE --> verwijderen

            Console.Write($"Wat wil je doen? ");
            string WatTeDoen = Console.ReadLine();
            List<string> Namen = new List<string>();
            List<int> Leeftijden = new List<int>();
            List<DateTime> Geboortedatums = new List<DateTime>();

            while (WatTeDoen != "STOP")
            {
                if (WatTeDoen == "ADD")
                {
                    Console.Write($"Naam: "); Namen.Add(Console.ReadLine());
                    Console.Write($"Leeftijd: "); Leeftijden.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write($"Geboortedatums: "); Geboortedatums.Add(Convert.ToDateTime(Console.ReadLine()));
                    Console.Write($"Wat wil je doen? "); WatTeDoen = Console.ReadLine();
                }
                else if (WatTeDoen == "ADJUST")
                {
                    Console.Write($"Welke persoon wil je aanpassen? ");
                    int index = Namen.IndexOf(Console.ReadLine());
                    
                    Console.Write($"Naam: "); Namen[index] = Console.ReadLine();
                    Console.Write($"Leeftijd: "); Leeftijden[index] = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Geboortedatums: "); Geboortedatums[index] = Convert.ToDateTime(Console.ReadLine());
                    Console.Write($"Wat wil je doen? "); WatTeDoen = Console.ReadLine();
                }
                else if (WatTeDoen == "DELETE")
                {
                    Console.Write($"Welke persoon wil je verwijderen? ");
                    int index = Namen.IndexOf(Console.ReadLine());
                    
                    Console.Write($"Naam: "); Namen.RemoveAt(index);
                    Console.Write($"Leeftijd: "); Leeftijden.RemoveAt(index);
                    Console.Write($"Geboortedatums: "); Geboortedatums.RemoveAt(index);
                    Console.Write($"Wat wil je doen? "); WatTeDoen = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Geef een juiste keuze in: ");
                    WatTeDoen = Console.ReadLine();
                }
            }


            for(int i = 0; i < Namen.Count; i++)
            {
                Console.WriteLine($"{Namen[i]}-{Leeftijden[i]}-{Geboortedatums[i]}");
            }
        }
    }
}