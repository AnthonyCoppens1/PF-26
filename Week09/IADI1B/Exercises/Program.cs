using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Using methods create the following:
            - read in a bunch of numbers as a string

            Then --> Make one or multiple methods that
            - split the numbers into an array
            - convert the given numbers so you can count with them
            - add the numbers up and print them out

            MAIN:
            string numbers = Console.ReadLine();
            ArrayConverterAndSum(numbers);

            */

            string numbers = Console.ReadLine();
            ArrayConverterAndSum(numbers);


            /*
            Second one: RPG BATTLER (player hp vs monster hp --> attack / heal / specialattack)
            Loop the battle up until your hp or the monster's hp goes down to 0

            HP PLAYER: 100
            HP MONSTER: 100
            Attack: random between 10-20
            Heal: random between 5-10
            SpecialAttack: 20-40

            Crit?? 10% chance to double next action (happens randomly)
            */
        }


        static void ArrayConverterAndSum(string numbers)
        {
            //Console.WriteLine(SUM(SplitAndConvert(numbers)));
            int[] converted = SplitAndConvert(numbers);
            int calculated = SUM(converted);
            Console.WriteLine(calculated);
        }

        static int SUM(int[] N)
        {
            int sum = 0;
            foreach (int number in N)
            {
                sum += number;
            }

            return sum;
        }

        static int[] SplitAndConvert(string s)
        {
            string[] splitNumbersString = s.Split();
            //alternativer to the full looped conversion below
            //int[] splitNumbersINT = Array.ConvertAll(splitNumbersString, Convert.ToInt32);

            int[] splitNumbersINT = new int[splitNumbersString.Length];

            for (int i = 0; i < splitNumbersString.Length; i++)
            {
                splitNumbersINT[i] = Convert.ToInt32(splitNumbersString[i]);
            }

            return splitNumbersINT;
        }
    }
}