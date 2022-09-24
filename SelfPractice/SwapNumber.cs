using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    class SwapNumber
    {
        public static void Swapping()
        {
            //take user input 
            Console.WriteLine("Enter the value for x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("berofr Swapping value of x : "+x+ "\nBefore swapping value of y : "+y);
            x = x + y;
            y = x - y;
            x= x - y;
            Console.WriteLine("After Swapping value of x : " + x + "\nAfter swapping value of y : " +y);

        }
    }
}
