using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLib
{
    public class daytime
    {
        long minutes;

        public daytime(long minutes)
            { this.minutes = minutes; }

        public static daytime operator +(daytime lhs, int minutes)
        {
            return new daytime(lhs.minutes + minutes);  
        }
        public override string ToString()
        {
            int year = 2023;
            int month = 1;
            int day = 1;
            int hour = 0;
            long remainingMinutes = minutes;

            while (remainingMinutes > 60)
            {
                hour++;
                remainingMinutes -= 60;
                while (hour > 24)
                {
                    day++;
                    hour -= 24;
                    while (day > 30)
                    {
                        day -= 30;
                        month++;
                        while (month > 52)
                        {
                            year++;
                            month -= 52;
                        }
                    }
                }
            } 
            return $"- {year} - {month:D2} - {day:D2} {hour:D2}:{remainingMinutes:D2}";
        }

    }
}
