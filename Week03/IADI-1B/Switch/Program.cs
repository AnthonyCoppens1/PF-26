using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekday = (int)DateTime.Now.DayOfWeek;
            string weekdayName = DateTime.Now.DayOfWeek.ToString();

            DateTime yesterday = new DateTime(2026,10,06);

            //if-statement
            if (weekday == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("WEEKEND WOHOOOOOOOOO");
            }

            weekdayName = "Sunday";
            //switch case
            switch (weekdayName)
            {
                case "Monday":
                    Console.WriteLine("first day");
                    break;
                case "Tuesday":
                    Console.WriteLine("best day");
                    break;
                case "Wednesday":
                    Console.WriteLine("middle day");
                    break;
                default:
                    Console.WriteLine("lame days");
                    break;
            }




            //something completely different
            Console.Write($"Give me number: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int x);

            if (check)
            {
                if (x > 10)
                {
                    Console.WriteLine("Wohoo");
                }
                else
                {
                    Console.WriteLine("BOOOO");
                }
            }
            else
            {
                Console.WriteLine("failed to convert, please type an actual number next time.");
            }




            //exercise on a heatwave checker for the pathetic Belgian weather
            double temp1 = Convert.ToDouble(Console.ReadLine());
            double temp2 = Convert.ToDouble(Console.ReadLine());
            double temp3 = Convert.ToDouble(Console.ReadLine());
            double temp4 = Convert.ToDouble(Console.ReadLine());
            double temp5 = Convert.ToDouble(Console.ReadLine());

            int highTempCounter = 0;
            int normalTemp25 = 0;
            if (temp1 >= 30)
            {
                highTempCounter++;
                normalTemp25++;
            }
            else if (temp1 >= 25)
            {   
                normalTemp25++;
            }
            //--------------

            if (temp2 >= 30)
            {
                highTempCounter++;
                normalTemp25++;
            }
            else if (temp2 >= 25)
            {   
                normalTemp25++;
            }
            //--------------

            if (temp3 >= 30)
            {
                highTempCounter++;
                normalTemp25++;
            }
            else if (temp3 >= 25)
            {   
                normalTemp25++;
            }
            //--------------

            if (temp4 >= 30)
            {
                highTempCounter++;
                normalTemp25++;
            }
            else if (temp4 >= 25)
            {   
                normalTemp25++;
            }
            //--------------

            if (temp5 >= 30)
            {
                highTempCounter++;
                normalTemp25++;
            }
            else if (temp5 >= 25)
            {   
                normalTemp25++;
            }
            //--------------


            if (highTempCounter >= 3 && normalTemp25 == 5)
            {
                Console.WriteLine("HEATWAVE");
            }
            else
            {
                Console.WriteLine("NO WAVE");
            }


        }
    }
}