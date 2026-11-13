using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexLes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = File.ReadAllText("Rapunzel.txt");
            string woord = "";
            int teller = 0;

            foreach (char c in tekst.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn'".Contains(c))
                {
                    woord += c;
                }
                else
                {
                    if (woord == "rapunzel")
                    {
                        teller++;
                    }
                    woord = "";
                }
            }

            Console.WriteLine($"aantal rapunzels: {teller}");

            /*
            rapunzel
            aa

            [a-z] --> range
            [a-zA-Z]
            [A-z0-9]
            [0-37-9]

            \w --> A-z 0-9 _ word characters '
            \W --> alles behalve word chars
            \d --> alle cijfers
            \D --> alles behalve cijfers
            \s
            \S
            \t tab
            \b --> word boundary

            [A-z]+

            + * ?
            + 1 of meer
            * 0 of meer
            ? 0 of 1

            \b[A-z]{4}\b
            
            [A-z\?]{3,5}? --> zo weinig mogelijk

            [A-z]{3,5}?

            ([A-z]{3,5}){2,}
            hairhairhair
            aaazzzzeeeee

            [^4] --> NOT, maar pas op, want het is echt alles behalve de 4

            (?=) --> positive look ahead
            (?!) --> negative look ahead

            king(?='s)
            

            (?<=) --> positive look behind
            (?<!) --> negative look behind

            (?<=:\s")(\b?[A-z]+\b)+"

            ^ $
            ^ start van de string
            $ einde
            ^RAPUNZEL

            contented$
            */

            //Regex patroon = new Regex("rapunzel|RAPUNZEL|Rapunzel");
            Regex patroon = new Regex("rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = patroon.Matches(tekst);
            Console.WriteLine($"aantal rapunzels opnieuw: {matches.Count}");

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

            string nieuwVerhaal = patroon.Replace(tekst, "Anthony");
            Console.WriteLine(nieuwVerhaal);
        }
    }
}