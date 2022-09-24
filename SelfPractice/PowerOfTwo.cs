using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class PowerOfTwo
    {
        public static void PowerOfTwoNumbers()
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            while (Number < 0 || Number >= 20)
            {
                Console.WriteLine("Invalid input ,plz enter the number");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
