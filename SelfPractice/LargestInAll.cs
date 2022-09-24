using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class LargestInAll
    {
        public static void Max()
        {
            int n1 = 25, n2 = 70, n3 = 46, max;
            //Using ternary operator
            max = (n1 > n2 && n1 > n2) ?
                n1 : (n2 > n3) ? n2 : n3;

            // Print the largest number
            Console.WriteLine("Largest number among " +
                             n1 + ", " + n2 + " and " +
                                    n3 + " is " + max);
        }
    }
}
}
