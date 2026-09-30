using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //OVERVIEW OF ALL VARIABLES / DATATYPES

            string name = "Anthony";
            char c = 'a';

            int z; //declaring
            z = 19; //intializing

            int a = -3; //immediately declaring and initializing

            int x, y; //declare multiple
            x = 5; y = 8;

            byte B = 12; //0-255
            short S = 12503;
            long L = 2348632487632423487;

            double numberDouble = 3.14582719;
            

            /*double DD = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine(DD + 5);*/

            float F = 3.14f;



            //AT THIS POINT X IS 5
            //prefix and postfix
            Console.WriteLine($"x has value: {x}");
            x++; //x = x + 1
            Console.WriteLine($"x has value: {x}");
            ++x; //x = x + 1
            Console.WriteLine($"x has value: {x}");

            //actually printing out the x++ / KEEP IN MIND X IS NOW 7!!!
            Console.WriteLine($"x++ results in {x++}"); //7
            Console.WriteLine($"++x results in {++x}"); //9
            Console.WriteLine($"x-- results in {x--}"); //9
            Console.WriteLine($"--x results in {--x}"); //7

            
            //ARITHMETIC OPERATORS --> x = 7, y = 8
            Console.WriteLine($"{x} + {y} = {x + y}"); // 15
            Console.WriteLine($"{x} - {y} = {x - y}"); // -1
            Console.WriteLine($"{x} * {y} = {x * y}"); // 56
            Console.WriteLine($"{x} / {y} = {x / y}"); // 0
            Console.WriteLine($"{x} % {y} = {x % y}"); // 7


            Console.WriteLine($"10 % 9 = {10 % 9}"); // 1
            Console.WriteLine($"10 % 7 = {10 % 7}"); // 3
            Console.WriteLine($"10 % 4 = {10 % 4}"); // 2
            Console.WriteLine($"10 % 2 = {10 % 2}"); // 0
            Console.WriteLine($"10 % 1 = {10 % 1}"); // 0



            //COMPOUND OPERATORS
            // += -= *= /= %=
            Console.WriteLine($"x starts at {x}"); // X IS 7
            x += 10;
            Console.WriteLine($"x is {x}"); // 17
            x -= 7;
            Console.WriteLine($"x is {x}"); // 10
            x *= 4; // x = x * 4;
            Console.WriteLine($"x is {x}"); // 40
            x /= 5;
            Console.WriteLine($"x is {x}"); // 8
            x %= 3;
            Console.WriteLine($"x is {x}"); // 2


            //text based compound operators
            name = "Anthony";
            name += " Coppens"; // name = name + "Coppens"
            Console.WriteLine(name);

            name = "Anthony";
            name = "Coppens " + name;
            Console.WriteLine(name);


            //COMPARISSON OPERATORS
            // > < >= <= == !=
            Console.WriteLine($"x = {x} and y = {y}");
            Console.WriteLine(x < y); //True
            Console.WriteLine(x >= y);
            x = 8; 
            Console.WriteLine(x == 8.0); //True
            Console.WriteLine(x != y);


            //WEIRD THINGS BEFORE THE BREAK
            Console.WriteLine(5 + 5); // 10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); // 58
            Console.WriteLine('a' + 5); //102
            Console.WriteLine('5' + '5'); //106
            Console.WriteLine("5" + '5' + 5);
            Console.WriteLine("5" + ('5' + 5));

            Console.WriteLine("" + (5 + 5));
            Console.WriteLine(5.ToString());


            //indexing in strings
            name = "Laetitia De Wouter D'Oplinter";
            char test = name[0];
            Console.WriteLine(test);
            Console.WriteLine(name[0]);
            Console.WriteLine(name.ElementAt(0));

            Console.WriteLine(name[name.Length-1]);

                


            
        }
    }
}