using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class Factorial
    {
        public static void FactorialNumber()
        {
            int Fact=1;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)

                Fact = Fact * i;
            {
                Console.WriteLine("Factorial of "+n+ " is " +Fact);
            }
        }
    }
}
