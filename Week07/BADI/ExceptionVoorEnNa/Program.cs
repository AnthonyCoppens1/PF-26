using System;
using System.IO;

namespace ExceptionVoorEnNa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oude manier vs de nieuwe manier hoe we iedere mogelijke fout er uit zouden halen
            //oude manier
            Console.Write($"Geef een filenaam: ");
            string file = Console.ReadLine();

            Console.Write($"Geef een aantal lijnen om te bekijken: ");
            int lijnnr;
            
            if (!Int32.TryParse(Console.ReadLine(), out lijnnr))
            {
                Console.WriteLine($"Geen correct lijnnr, we stoppen!");
                return;
            }

            if (!File.Exists(file))
            {
                Console.WriteLine("Geen correct file, we stoppen opnieuw");
                return;
            }
            else
            {
                string[] tekst = File.ReadAllLines(file);
                if (lijnnr < 0 || lijnnr > tekst.Length)
                {
                    Console.WriteLine("Index niet juist, ik stop");
                    return;
                }
                for (int i = 0; i < lijnnr; i++)
                {
                    Console.WriteLine(tekst[i]);
                }
            }




            //nieuwe manier
            try
            {
                Console.Write($"Geef een filenaam: ");
                file = Console.ReadLine();

                Console.Write($"Geef een aantal lijnen om te bekijken: ");
                int lijnen = Convert.ToInt32(Console.ReadLine());

            
                string[] tekst = File.ReadAllLines(file);
                if (lijnen < 0 || lijnen > tekst.Length)
                {
                    throw new IndexOutOfRangeException();
                }


                for (int i = 0; i < lijnen; i++)
                {
                    Console.WriteLine(tekst[i]);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File niet gevonden");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("fout datatype");
                Console.WriteLine(ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"foute index");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"te groot getal");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }


        }
    }
}