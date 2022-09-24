using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class CheckAlphabets
    {
        public static void AlphaUpperLowerCase()
        {
            char ch;
            Console.WriteLine("Write any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + " Is Lower case alphabet");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " Is Upper case Alphabet");
            }
            else
            {
                Console.WriteLine(ch + "Is not an alphabet ");
            }
        }
    }
}
