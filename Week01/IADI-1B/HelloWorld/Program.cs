using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //this is just an instruction no second line is possible
            /*
            This is text
            this too
            no worries
            */


            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            int number = 5;

           //technique 1: concatenation
            Console.WriteLine("Hello " + "senior " + number);

            //second way
            Console.WriteLine($"Hello {name}!");

            //third way
            /*name = "0";
            number = 1;*/
            Console.WriteLine("Hello {0} and {1}!", name, number);
        }
    }
}