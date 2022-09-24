using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class Factors
    {
        public static void FactorsOfNumber()
        {
            Console.WriteLine("Enter the number ");
            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors of " + Number + " are :");

            for (int i = 1; i <= Number; i++)
            {
                if (Number%i == 0 )
                {
                    Console.Write(i+ " , ");
                }
            }
        }
    }
}
