using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class ArmstrongNumber
    {
        //Armstrong number is a number that is equal to the sum of cubes of its digits. For example 0, 1, 153, 370, 371 and 407 s
        public static void ArmstrongNum()
        {
            Console.WriteLine("Enter the Number :");
            int Number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int r = 0;
            int temp = Number;
            while (Number > 0)
            {
                r = Number % 10;
                sum = sum + (r * r * r);
                Number = Number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Armstrong Number");
            }
            else
            {
                Console.WriteLine("Number is not an Armstrong number");
            }
        }
    }
}
