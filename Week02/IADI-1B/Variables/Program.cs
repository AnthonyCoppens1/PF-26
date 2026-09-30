using System;


namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //small recap of last week as well as some new parts
            //OVERVIEW
            //TEXT
            string s = "Anthony";
            string name = "Coppens";

            char c = 'a';
            char space = ' '; //spacebar is also a character




            //NUMBERS
            //delaring multiple datatypes at a time
            int x, y; //declaring --> also grouping the same type --> 32 BIT integer
            x = 5; y = 5; //initializing --> giving it a value

            byte numberByte = 12; //0 - 255 --> always unsigned
            //byte B = 256; --> TOO BIG

            short shortie = -2000; // 16 bit integer
            long L = 2349283749873249732; //64 bit integer --> insanely long --> e19





            //DECIMALS
            double D = 40.58249162347; //15 decimals past the .
            float numberFloat = 3.14528f;



            //s name space c x y numberByte shortie L D numberFloat
            Console.WriteLine(name);
            Console.WriteLine(space);
            Console.WriteLine($"x {x} + y {y} = {x+y}");

            Console.WriteLine(shortie);
            Console.WriteLine(D);


            string input = Console.ReadLine();
            double DD = Convert.ToDouble(input); //careful this is default a string

            Console.WriteLine(DD + 5);


            //SOMETHING DIFFERENT
            //PREFIX POSTFIX
            Console.WriteLine($"x: {x} and y: {y}");

            // x++ OR ++x --> x-- OR --x
            Console.WriteLine("x: " + x);
            x++;
            Console.WriteLine("x: " + x);
            Console.WriteLine($"{x++}");
            Console.WriteLine(x);

            Console.WriteLine($"Current value of x: {x}");
            Console.WriteLine($"{++x}");
            Console.WriteLine($"FINAL VALUE: {x}");


            Console.WriteLine($"LAST OVERVIEW, X STARTS AT: {x}");
            Console.WriteLine($"x++ results in {x++}");
            Console.WriteLine($"++x results in {++x}");            
            Console.WriteLine($"x-- results in {x--}");            
            Console.WriteLine($"--x results in {--x}");


            //Arithmetic operators
            x = 8; y = 5;
            Console.WriteLine($"{x} + {y} = {x + y}"); // x = 8 , y = 5
            Console.WriteLine($"{x} - {y} = {x - y}"); //3
            Console.WriteLine($"{x} * {y} = {x * y}"); //40
            Console.WriteLine($"{x} / {y} = {x / y}"); //1 --> technically a whole division as long as
            //BOTH are a whole number (int)
            Console.WriteLine(7.0 / 2); //results in a decimal value as soon as 1 of the 2 is a decimal.
            Console.WriteLine($"{x} % {y} = {x % y}"); // 3

            //some more examples on module
            Console.WriteLine($"10 % 9 = {10 % 9}"); //1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //2
            Console.WriteLine($"10 % 7 = {10 % 7}"); //3
            Console.WriteLine($"10 % 5 = {10 % 5}"); //0
            Console.WriteLine($"10 % 3 = {10 % 3}"); //1
            Console.WriteLine($"10 % 2 = {10 % 2}"); //0
            Console.WriteLine($"10 % 1 = {10 % 1}"); //0


            //COMPOUND OPERATORS
            Console.WriteLine();
            Console.WriteLine("\ncompound operators");
            Console.WriteLine($"x starts at: " + x); // X IS 8
            x += 10; // x = 8 (old value of x) + 10
            Console.WriteLine(x); //18
            x -= 7; // x = 18(OV) - 7
            Console.WriteLine(x); //11
            x *= 15; // x = 11(OV) * 15
            Console.WriteLine(x); //165
            x /= 5; // x = 165 (OV) / 5
            Console.WriteLine(x); //33
            x %= 3; // x = 33 % 3
            Console.WriteLine(x); //0


            //strings and compound operators
            name = "Anthony ";
            name += "Coppens";
            Console.WriteLine(name);

            name = "Anthony";
            name = "Coppens " + name;
            Console.WriteLine(name);


            //SPECIAL CASES
            Console.WriteLine(5 + 5); //10
            Console.WriteLine('5' + 5); // ascii value of '5' = 53 + 5
            Console.WriteLine('5' + 'a'); //150, grabs the value behind

            Console.WriteLine("" + 5 + 5);
            Console.WriteLine("" + (5 + 5));

            //Something useful at the end --> CHAR RELATED
            name = "Walter";
            char firstLetter = name[0];
            Console.WriteLine($"Walter's first letter is {firstLetter}");
            char also = name.ElementAt(0);
            Console.WriteLine($"Walter's first letter is  ALSO {also}");


            Console.WriteLine(name.Length);
            char LAST = name[name.Length-1];
            Console.WriteLine($"Walter's last letter is: {LAST}");

            














        }
    }
}