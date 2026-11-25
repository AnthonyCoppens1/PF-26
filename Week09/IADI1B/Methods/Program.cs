using System;
using System.Data;
using System.Globalization;
using System.IO.Pipes;

namespace Methods
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            HelloWorld();

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = Add(number1, number2);
            Console.WriteLine(sum);


            int[] numbers = {3, 1, 7, 9, 5, 2, 4};
            run(numbers);


            int[] numbers2 = {9, 8, 7, 6, 5, 4, 3, 2, 1};
            run(numbers2);

            int size = Convert.ToInt32(Console.ReadLine());
            //int[] moreNumbers = Fill(size);
            //run(moreNumbers);
            //above here is another option as alternative to the line below
            run(Fill(size));
            run(Fill());

            //parameter overloading
            string[] words = {"some", "words", "here"};
            Print(words);
            
            double[] DD = {1.2, 5.8, -3.9};
            Print(DD);



            //passing by value vs passing by reference
            //passing by value is without the ref
            //passing by reference passes on the whole variable name, savespot and value

            int studentGrade = 75;
            Console.WriteLine($"Grade of the student before extra credit: {studentGrade}");
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine($"Grade of the student AFTER extra credit: {studentGrade}");


            //with value types it's a different story

            int[] grades = new int[1];
            grades[0] = 80;
            Console.WriteLine($"Grade of the student before extra credit: {grades[0]}");
            GiveExtraCreditArray(grades);
            Console.WriteLine($"Grade of the student AFTER extra credit: {grades[0]}");


            //return multiple items
            int a = 15;
            int b = 18;
            Console.WriteLine($"a: {a} and b: {b}");
            //Swap(ref a, ref b);
            (a,b) = Swap(a,b);
            Console.WriteLine($"a: {a} and b: {b}");


            int add;
            int multiply;
            AddandMultiply(5, 10, out add, out multiply);
            Console.WriteLine($"addition: {add} and multiplication: {multiply}");

            //optional parameters
            AddValues(5);
            AddValues(y:15, z:28);

        }

        static void AddValues(int x = 10, int y = 5, int z = 3)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }


        static void AddandMultiply(int a, int b, out int add, out int multiply)
        {
            add = a + b;
            multiply = a * b;
        }

        static (int, int) Swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            return (a,b);
        }

        /*static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }*/



        static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }


        static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }



        static int[] Fill(int size = 10)
        {
            Random rd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(0, 101);
            }
            return array;
            //Array.Sort(array); --> anything below a return is dead code
            
        }

        static void run(int[] NEWNUMBERS)
        {
            Print(NEWNUMBERS);
            Array.Sort(NEWNUMBERS);
            Print(NEWNUMBERS);
        }

        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Print(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
        
        static void HelloWorld()
        {
            Console.WriteLine($"Hello dear user, hope you're doing fine");
        }
    }
}