using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode29.Day1
{
    class Day1
    {
        public Day1()
        {
            int y = Convert.ToInt32(Console.ReadLine());
            DateTime dtDayOfProgrammer = new DateTime() ;
            if (y >= 1700 && y <= 2700)
            {
                //determine calendar to Use
                bool leapYear = false;
                
                if (y >= 1700 && y <= 1917)//julian calendar
                {
                    leapYear = (y % 4 == 0);
                    dtDayOfProgrammer = new DateTime(y, 01, 01).AddDays(255);
                }
                else if (y >= 1700 && y <= 1917)//gregorian
                {
                    leapYear = (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0));
                }

                if (y != 1918)
                    dtDayOfProgrammer = new DateTime(y, 01, 01).AddDays(255);
                else
                    dtDayOfProgrammer = new DateTime(y, 02, 14).AddDays(255 - 32);

            }
            Console.WriteLine(dtDayOfProgrammer.ToString("dd.MM.yyyy"));
            
        }


    }
}
