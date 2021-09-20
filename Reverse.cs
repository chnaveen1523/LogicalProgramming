using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_CS
{
    class Reverse
    {
        public static void ReverseNumber()
        {
            int rem = 0;
            int rev = 0;
            Console.WriteLine("Enter a number to reverse:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The reverse of the given number is:" + rev);
        }
    }
}