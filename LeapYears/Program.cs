using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYears
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program asks for a starting year and an ending year, and then prints all of 
            // the leap years between them (and including them, if they are also leap years). 
            // Leap years are years divisible by four (like 1984 and 2004). However, years divisible by 100 
            // are not leap years (such as 1800 and 1900) unless they are divisible by 400 (like 1600 and
            // 2000, which were in fact leap years).

            Console.WriteLine(" ----- Leap Year Check ----- ");
            Console.Write("Please enter a starting year (YYYY): ");
            string startyear = Console.ReadLine();
            Console.Write("Please enter an ending year (YYYY): ");
            string endyear = Console.ReadLine();
            Console.WriteLine();
            int start = int.Parse(startyear);
            int end = int.Parse(endyear);
            for (int i = start; i <= end; i++)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    Console.WriteLine("Year {0} is a leap year.", i);
                }
                    
                else if (i % 4 == 0)
                    Console.WriteLine("Year {0} is a leap year.", i);
            }
            Console.ReadLine();
        }
    }
}
