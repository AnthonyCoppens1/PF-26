using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World again!");
            
            //This is some extra explanation that you can add in here

            //Console.Write("Help me!");

            /*Console.Write("I don't know what I'm doing???");
            Console.WriteLine("TEST");*/

            /* */

            //FIRST DECLARE
            string name;

            //NEXT INITIALIZE
            name = "Juliana";
            string name2 = "Anthony";

            //3 techniques
            //number 1
            Console.WriteLine("Hello " + name);

            //number 2
            Console.WriteLine($"Hello {name}");

            //number 3
            Console.WriteLine("Hello {0} and {1}", name, name2);



            int number = 7;
            int secondNumber = 12;

            Console.WriteLine("Hello" + number);




            name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"Hello {Console.ReadLine()}");
            

        }
    }
}