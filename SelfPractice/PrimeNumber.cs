using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class PrimeNumber
    {
        public static void PrimeNum()
        {
            //we use count here because prime number is divisible ony 2 numbers.
            //like two numbers are 1 or number itself, like 7 is a prime number bcz its dividible number is 1 and 7
            //like 8 is not prime number bcz 8 divisible by 4 numbers like 1,2,4,8 ,so we use here count
            int count = 0;
            Console.WriteLine("Enter the value for n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
               if (n % i ==0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Entered Number is a primeNumber");
            }
            else
            {
                Console.WriteLine("Entered Number is not a primeNumber");
            }
        }
    }
}
