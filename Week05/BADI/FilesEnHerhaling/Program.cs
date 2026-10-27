using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Magische getallen
            //getal splitsen en ieder cijfer in kwadraat, dan checken of nieuw totaal
            //>= 10, zoniet, stopt de reeks.

            string s = Console.ReadLine(); 

            while (Convert.ToInt32(s) >= 10)
            {
                int som = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    som += Convert.ToInt32(s[i].ToString()) * Convert.ToInt32(s[i].ToString());
                }

                Console.WriteLine(som);
                s = som.ToString();
            }
            Console.WriteLine("EINDE\n");


            StreamWriter stroom = File.CreateText("file.txt");
            stroom.WriteLine("Dit is de start van het bestand");
            stroom.WriteLine("Meer tekst op de tweede lijn");
            stroom.Write(" test om te zien wat er hier zal gebeuren");
            stroom.Write("EN NOG MEER");
            stroom.Close();

            stroom = File.CreateText(@"C:\BADI\file.txt");
            stroom.WriteLine("ene zin");
            stroom.Close();


            /*string afbeeldingen = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string pad = Path.Combine(afbeeldingen, "bestand.txt");
            stroom = File.CreateText(pad);
            stroom.WriteLine("Random bestand bij de afbeeldingen");
            stroom.Close();

            if (File.Exists(pad))
            {
                stroom = File.AppendText(pad);
                stroom.WriteLine("TEST TES");
                stroom.Close();
            }*/
            string afbeeldingen = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string pad = Path.Combine(afbeeldingen, "bestand.txt");
            if (File.Exists(pad))
            {
                File.Delete(pad);
            }


        }
    }
}