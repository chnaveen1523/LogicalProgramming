using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_CS
{
    class Perfect
    {
        //static variables
        public static int num;
        public static int sum = 0;
        public static int IsPerfect()
        {
            //Taking input from the user
            Console.WriteLine("Enter a numbers:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static void PerfectNumber()
        {
            Perfect.IsPerfect();
            if (num == sum)
            {
                Console.WriteLine("{0} is a perfect number", +num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", +num);
            }
        }
    }
}