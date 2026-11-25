using System;

namespace ArrayConverterAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine(); //"10 15 20 -3 17"
            ConvertedAndCalcSum(answer);
        }

        static void ConvertedAndCalcSum(string input)
        {
            //Console.WriteLine(CalcSum(SplitAndConvert(input)));
            
            int[] CONVERTED = SplitAndConvert(input);
            int addition = CalcSum(CONVERTED);
            Console.WriteLine(addition);
        }

        static int CalcSum(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }

            return sum;
        }

        static int[] SplitAndConvert(string input) //"10 15 20 -3 17"
        {
            string[] numberString = input.Split();
            int[] convertedString = new int[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                convertedString[i] = Convert.ToInt32(numberString[i]); //from "10" --> 10
            }
            //int[] CONVERTED = Array.ConvertAll(numberString, Convert.ToInt32); --> an alternative for your conversion

            return convertedString;
        }
    }
}