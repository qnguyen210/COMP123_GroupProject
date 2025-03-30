using AccountLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayTime date = new DayTime();

            Console.WriteLine(date);  // - 2023 - 01 - 01 00:00 

            date += 518400;         //add one year 

            Console.WriteLine(date);  // - 2024 - 01 - 01 00:00 

            date += 43200;          //add one month 

            Console.WriteLine(date);  // - 2024 - 02 - 01 00:00 

            date += 1440;           //add one day 

            Console.WriteLine(date);  // - 2024 - 02 - 02 00:00 

            date += 60;              //add one hour 

            Console.WriteLine(date);  // - 2024 - 02 - 02 01:00 

            date += 35;              //add 35 minutes 

            Console.WriteLine(date);  // - 2024 - 02 - 02 01:35 
        }
    }
}
