using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    public class LeapYear
    {
        public void checkLeapYear()
        {
            Console.WriteLine("Enter a Year");
            int year=Convert.ToInt32(Console.ReadLine());
            if (year == 0)
            {
                Console.WriteLine("Please enter a valid year");
            }
            else
            {
                if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year", year );
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year",year);
                }
            }
        } 
    }
}
