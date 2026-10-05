using System;

namespace VariabelenEnExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //SAMENVATTING VAN VARIABELEN MET ENKELE VOORBEELDEN
            string naam = "Anthony"; //Declareren en initialiseren
        
            char a = 'a';

            int x, y; //declareren
            x = 5; y = 8; //initialiseren

            byte B = 15;
            short s = -15208;
            long L = 2349873249872349873;

            double D = 3.14;
            float f = 3.14f;


            //postfix en prefix
            // x++ ++x --> x-- --x
            Console.WriteLine($"x = {x} en y = {y}");
            x++; // hetzelfde als x = x + 1
            Console.WriteLine($"x = {x}");
            --x; // hetzelfde als x = x - 1
            Console.WriteLine($"x = {x}");

            //2e variant
            Console.WriteLine($"x++ geeft als resultaat: {x++}");
            Console.WriteLine($"++x geeft als resultaat: {++x}");
            Console.WriteLine($"x-- geeft als resultaat: {x--}");
            Console.WriteLine($"--x geeft als resultaat: {--x}");


            //ARITHMETIC OPERATORS / REKENKUNDIGE OPERATOREN
            // + - * / % en dan voor de speciallekes: Math.Pow , ...

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} / 2.5 = {x / 2.3}");

            Console.WriteLine($"{x} % {y} = {x % y}");

            /*double kommaGetal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(kommaGetal + 5);*/

            //Nog wat voorbeelden van MODULO %
            Console.WriteLine($"10 % 9 = {10 % 9}"); //1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //2
            Console.WriteLine($"10 % 5 = {10 % 5}"); //0
            Console.WriteLine($"10 % 3 = {10 % 3}"); //1
            Console.WriteLine($"10 % 2 = {10 % 2}"); //0
            Console.WriteLine($"10 % 1 = {10 % 1}"); //0


            //COMPOUND OPERATORS of verkorte schrijfwijze van rekenkundige operatoren
            Console.WriteLine($"x start op {x}"); // 5
            x += 10;
            Console.WriteLine(x); // 15
            x -= 5;
            Console.WriteLine(x); // 10
            x *= 4;
            Console.WriteLine(x); // 40
            x /= 3;
            Console.WriteLine(x); // 13
            x %= 5;
            Console.WriteLine(x); // 3


            //STRING VARIANTEN
            naam = "Adam"; //naam = naam + "..."
            naam += " Steenhoudt";
            Console.WriteLine(naam);

            naam = "Adam";
            naam = "Steenhoudt " + naam;
            Console.WriteLine(naam);


            //SPECIALE ZAKEN, LET HIERBIJ OP!!
            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); // 55
            Console.WriteLine('5' + 5); // 58 --> decimale waarde van symbool 5 + getal 5
            Console.WriteLine('5' + '5'); //106
            Console.WriteLine("" + 5 + 5); // 55
            Console.WriteLine("" + (5 + 5)); // 10

            // > < >= <= == !=
            Console.WriteLine($"x {x} en y {y}");
            Console.WriteLine(x > y); //False
            Console.WriteLine(x <= y); //True

            Console.WriteLine(y == 8.0); //True
            Console.WriteLine(x != y); //True








        }
    }
}