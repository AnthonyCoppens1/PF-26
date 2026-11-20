using System;

namespace ExceptionBeforeAndAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we want to read in a specific number of lines from a file
            /*Console.Write($"Enter a number of lines: ");
            int nr = Convert.ToInt32(Console.ReadLine()); //10
            StreamReader file = File.OpenText("english.txt");
            //i = 0     -    nr = 10   -   i > nr --> 0 > 10
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine(file.ReadLine());
            }*/

            //before and after
            //old way
            Console.Write($"Enter a filename: ");
            string file = Console.ReadLine();

            Console.Write($"Enter a line you want to look at: ");
            
            if (!Int32.TryParse(Console.ReadLine(), out int lineNumber))
            {
                Console.WriteLine($"I end my code here, wrong linenumber!");
                return;
            }

            if (!File.Exists(file))
            {
                Console.WriteLine($"The file doesn't exist, is not in the CWD or is misspelled");
                return;
            }
            else
            {
                string[] text = File.ReadAllLines(file);
                if (lineNumber < 0 || lineNumber > text.Length)
                {
                    Console.WriteLine($"Linenumber is too big or negative!");
                    return;
                }

                Console.WriteLine(text[lineNumber]);
            }




            //new way
            try
            {
                Console.Write($"Enter a filename: ");
                file = Console.ReadLine();
                Console.Write($"Enter a line you want to look at: ");
                lineNumber = Convert.ToInt32(Console.ReadLine());
                string[] text = File.ReadAllLines(file);

                if (lineNumber > 10 && lineNumber < 20)
                {
                    throw new Exception();
                }
                Console.WriteLine(text[lineNumber]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Wrong datatype");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index is negative or too big");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"number too big for datatype");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Wrong location or file misspelled");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"PROBLEM");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}