using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class Palindrome
    {
        //palindrome means same after reverse like 121
        public static void PalindromeNum()
        {
            int result;
            int sum = 0;
            int temp;
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                result = num % 10;
                sum = (sum * 10) + result;
                num = num / 10;
            }
            if (temp == sum)

                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is not Palindrome");
        }
    }
}
