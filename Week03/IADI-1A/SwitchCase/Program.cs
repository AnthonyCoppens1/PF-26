using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*int weekday = (int)DateTime.Now.DayOfWeek;
           string dayInWords = DateTime.Now.DayOfWeek.ToString();
           Console.WriteLine(dayInWords);
           Console.WriteLine(weekday);

            switch (dayInWords) //dayInWord == "Monday"
            {
                case "Monday":
                    Console.WriteLine("First day");
                    break;
                case "Tuesday":
                    Console.WriteLine("2nd day");
                    break;
                case "Wednesday":
                    Console.WriteLine("BEST day");
                    break;
                case "Thursday":
                    Console.WriteLine("lame day");
                    break;
                case "Friday":
                    Console.WriteLine("almost weekend day");
                    break;
                default:
                    Console.WriteLine("WOHOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO weekend");
                    break;
            }

            int dayOfYear = DateTime.Now.DayOfYear;
            Console.WriteLine(dayOfYear);
            Console.WriteLine();*/



            double bill = Convert.ToDouble(Console.ReadLine());
            int people = Convert.ToInt32(Console.ReadLine());
            int rating = Convert.ToInt32(Console.ReadLine());
            
            switch (rating)
            {
                case 1: // 0%
                    double tip = (bill / 100) * 0;
                    double total = bill + tip;

                    double share = total / people;
                    share = Math.Ceiling(total * 2) / 2;

                    double extra = (share * people) - total;
                    Console.WriteLine($"Current bill: €{bill}, the tip: €{tip}, total: €{total}, " +
                    $"each person's share: €{share}, group has to pay €{extra:F2} extra");
                    if (share > 50)
                    {
                        Console.WriteLine("WARNING");
                    }
                    break;
                
                case 2: // 5%
                    tip = (bill / 100) * 5;
                    total = bill + tip;

                    share = total / people;
                    share = Math.Ceiling(share * 2) / 2;

                    extra = (share * people) - total;
                    Console.WriteLine($"Current bill: €{bill}, the tip: €{tip}, total: €{total}, " +
                    $"each person's share: €{share}, group has to pay €{extra} extra");
                    if (share > 50)
                    {
                        Console.WriteLine("WARNING");
                    }
                    break;
                
                case 3: //10 %
                    tip = (bill / 100) * 10;
                    total = bill + tip;

                    share = total / people;
                    share = Math.Ceiling(share * 2) / 2;

                    extra = (share * people) - total;
                    Console.WriteLine($"Current bill: €{bill}, the tip: €{tip}, total: €{total}, " +
                    $"each person's share: €{share}, group has to pay €{extra} extra");
                    if (share > 50)
                    {
                        Console.WriteLine("WARNING");
                    }
                    break;
                
                case 4: // 15 %
                    tip = (bill / 100) * 15;
                    total = bill + tip;

                    share = total / people;
                    share = Math.Ceiling(share * 2) / 2;

                    extra = (share * people) - total;
                    Console.WriteLine($"Current bill: €{bill}, the tip: €{tip}, total: €{total}, " +
                    $"each person's share: €{share}, group has to pay €{extra} extra");
                    if (share > 50)
                    {
                        Console.WriteLine("WARNING");
                    }
                    break;
                
                case 5: // 20 %
                    tip = (bill / 100) * 20;
                    total = bill + tip;

                    share = total / people;
                    share = Math.Ceiling(share * 2) / 2;

                    extra = (share * people) - total;
                    Console.WriteLine($"Current bill: €{bill}, the tip: €{tip}, total: €{total}, " +
                    $"each person's share: €{share}, group has to pay €{extra} extra");
                    if (share > 50)
                    {
                        Console.WriteLine("WARNING");
                    }
                    break;
                
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }

        }
    }
}