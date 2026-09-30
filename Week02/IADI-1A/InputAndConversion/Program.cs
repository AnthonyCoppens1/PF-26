using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input conversion
            Console.Write("Enter a byte: ");
            string answer = Console.ReadLine();
            byte B = Convert.ToByte(answer);
            Console.WriteLine(B + 5);

            Console.Write("Enter a short: ");
            short S = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(S + 10);


            int x = Convert.ToInt32(Console.ReadLine());

            //implicit and explicit conversion
            Console.WriteLine(S); //printing out the Short --> IMPLICIT
            Console.WriteLine(S.ToString()); //EXPLICIT
            Console.WriteLine("CHAR BELOW");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(c);
            Console.WriteLine((int)c);

            //WEIRDNESS AGAIN
            string name = "Anthony";
            //int nameToNumber = (int)name; --> DOES NOT WORK
            //int stringNumber = (int)"89";  --> NEVER WORKS, you have to either convert or parse! CANNOT CAST
            int number = (int)78.91456;
            Console.WriteLine(number);

            number = Convert.ToInt32(Math.Floor(78.91456));
            Console.WriteLine(number);

            double DD = (double)78;
            Console.WriteLine(DD);

        }
    }
}