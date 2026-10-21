using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*RECAP EXERCISE: MAGICAL NUMBERS
            1. Read in a user input (number)
            2. Split the number in its digits and square each one of them.
            3. Add the square digits together into a sum
            4. Check if the sum is smaller than 10, if not, repeat step 2, 3, 4.
            5. If you've reached a number smaller than 10, end the cycle.

            e.g. 27 --> 2² + 7² = 53 --> 5² + 3² = 34 --> 3² + 4² = 25 --> 2² + 5² = 29 --> 2² + 9² = 85
            --> 8² + 5² = 89 --> 8² + 9² = 145 --> 1² + 4² + 5² = 32, ....
            */

            string x = Console.ReadLine();

            while (Convert.ToInt32(x) > 10)
            {
                double sum = 0;
                int length = x.Length;

                for (int i = 0; i < length; i++)
                {
                    char digit = x[i];

                    sum += Math.Pow(Convert.ToInt32(digit.ToString()), 2);
                }
                Console.WriteLine(sum);
                x = sum.ToString();
            }

            Console.WriteLine("\n---------------------------------------------\n");

            //WRITING FILES
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("This is a first check of the file");
            stream.WriteLine("ANTHONY");
            stream.Write("This is line 3, ");
            stream.Write("WITH MORE TEXT BEHIND THE LINE!");
            stream.Close();

            stream = File.CreateText(@"C:\TESTFOLDER\file.txt");
            stream.WriteLine("Small file on my c-drive");
            stream.Close();

            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopFolder, "file.txt");
            stream = File.CreateText(path);
            stream.WriteLine("WEIRD ASS FILE ON THE DEKSTOP, NO CLUE WHAT IT IS DOING HERE");
            stream.Close();


            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("ADDING TEXT TO ANOTHER LINE");
                stream.WriteLine("MORE FOR THE VISUALS");
                stream.Close();
            }

            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string newMusic = Path.Combine(musicFolder, "weird.txt");
            stream = File.CreateText(newMusic);
            stream.WriteLine("TEST");
            stream.Close();
            
            if (File.Exists(newMusic))
            {
                File.Delete(newMusic);
            }
        }
    }
}