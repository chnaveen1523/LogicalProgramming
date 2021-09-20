using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram.cs
{
    class Prime
    {
        public static void PrimeNumber()
        {
            int flag = 0;
            Console.WriteLine("Enter a number to check prime:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number", +num);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is a prime number", +num);
            }
        }
    }
}