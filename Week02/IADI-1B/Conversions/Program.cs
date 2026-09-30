using System;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STILL SOMETHING SMALL FROM THE PREVIOUS FILE
            //COMPARISSON OPERATORS: < > <= >= == !=
            int x = 2; int y = 5; //ANSWERS ALWAYS True or False
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);

            Console.WriteLine(x == 2.0);
            Console.WriteLine(x != y);


            //CONVERSIONS
            Console.WriteLine($"Enter a number: ");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            Console.WriteLine(number);

            //explicit and implicit conversion
            Console.WriteLine(number); //IMPLICIT CONVERSION
            Console.WriteLine(number.ToString()); //EXPLICIT CONVERSION

            //casting
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c);
            Console.WriteLine((int)c);

            number = (int)78.92132138;
            Console.WriteLine(number);

            //int nameToNumber = (int)"Anthony"; --> DOES NOT WORK
            //int stringToNumber = (int)"78"; --> ALSO DOES NOT WORK

        }
    }
}