using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class HarmonicNumber
    {
        public static void HarmonicNum()
        {
            Console.WriteLine("Enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            while (Number <= 0)
            {
                Console.WriteLine("input Valid: Enter the Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            float Result_Harmonic = 0;
            for (float i = 1; i <= Number; i++)
            {
                
                Result_Harmonic += 1 / i;
                
            }
            Console.WriteLine("the Harmonic Result is " + Result_Harmonic);

        }
    }
}
