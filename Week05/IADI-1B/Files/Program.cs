using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*RECAP EXERCISE FOR LOOPS
            ============== magical numbers ==================

            1. Ask the user for a given number and split the number into its digits.
            2. Square every single digit and add the squared amounts up into a sum.
            3. Check if the new number is < 10.
            If not? Keep on repeating step 2.

            Keep in mind that you can use indexes of a string to also get the digits.
            Indexes are used with [ ] brackets.            
            */

            int x = Convert.ToInt32(Console.ReadLine());

            while (x >= 10)
            {
                double sum = 0;
                int length = x.ToString().Length; //27 --> length: 2
                for (int i = 0; i < length; i++)
                {
                    char digit = x.ToString()[i];
                    sum += Math.Pow(Convert.ToInt32(digit.ToString()), 2);
                }
                Console.WriteLine(sum);
                x = (int)sum;
            }


            Console.WriteLine($"\nStarting with theory on files:");

            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("This is a test file with some text inside.");
            stream.Write("This text appears on the next line, but my cursor stays HERE: ");
            stream.Write("My name is Anthony");
            stream.Close();

            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("test file in different location");
            stream.Close();

            //grab and create a file on your own dekstop
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopFolder, "smallFileOfText.txt");
            stream = File.CreateText(path);
            stream.WriteLine($"HELLO DEAR STUDENTS!");
            stream.Close();

            //appending, does not overwrite the existing file, it adds onto it. Whereas createtext will replace
            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("MORE TEXT");
                stream.Close();
            }

            //deleting files, BE CAREFUL!
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string pathWITHmusic = Path.Combine(musicPath, "file.txt");
            /*stream = File.CreateText(pathWITHmusic);
            stream.Close();*/

            if (File.Exists(pathWITHmusic))
            {
                File.Delete(pathWITHmusic);
            }



        }
    }
}