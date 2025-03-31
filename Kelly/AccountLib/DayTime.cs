using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLib
{
    public struct DayTime
    {
        public long minutes;

        public DayTime(long minutes)
        {
            this.minutes = minutes;
        }

        public static DayTime operator +(DayTime lhs, int minutes)
        {
            return new DayTime(lhs.minutes + minutes);
        }

        public override string ToString()
        {
            int year = 2023;
            int month = 1;
            int day = 1;
            int hour = 0;
            long remainingMinutes = minutes;

           
            hour = (int)(remainingMinutes / 60);
            remainingMinutes %= 60;

            
            day += hour / 24;
            hour %= 24;

            month += (day - 1) / 30;  
            day = ((day - 1) % 30) + 1;

            year += (month - 1) / 12;
            month = ((month - 1) % 12) + 1;

            return $"- {year} - {month:D2} - {day:D2} {hour:D2}:{remainingMinutes:D2}";
        }
    }
}