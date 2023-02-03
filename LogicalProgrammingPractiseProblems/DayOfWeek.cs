using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class DayOfWeek
    {
        public static void WeekDay()
        {
            int d1, m1, y1, x;
            String day = null;
            Console.WriteLine("Enter the day : ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month : ");
            int m = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the year : ");
            int y = Convert.ToInt32(Console.ReadLine());

            y1 = y - (14 - m) / 12;
            x = y1 + ((y1 / 4) - (y1/ 100 + y1/ 400)); ;
            m1 = m + ((12 * ((14 - m) / 12)) -2);
            d1 = (d + x + ((31 * m1) / 12)) % 7;

            switch (d1)
            {
                case 0:
                    day = "sunday";
                    break;
                case 1:
                    day = "monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "saturday";
                    break;
               
            }
            Console.WriteLine("Day of the week = " + day);
        }
    }
}
