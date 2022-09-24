using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public  class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("Enter the year");
            int Year = Convert.ToInt32(Console.ReadLine());
            while (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Invalid input : Enter the Year");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            if(Year % 4 == 0 || Year % 100 == 0 || Year % 400 == 0)
            {
                Console.WriteLine("year is a leap year");
            }
            else
            {
                Console.WriteLine("Not a Leap year");
            }
        }
        
    }
}
