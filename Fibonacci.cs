using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram.cs
{
    class Fibonacci
    {
        public static void FibonacciSeries()
        {
            //local variables
            int count = 10;
            int res;
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            //int num1=0;
            //int num2=1;
            for (int i = 2; i <= count; i++)
            {
                res = num1 + num2;
                Console.WriteLine("" + res);
                num1 = num2;
                num2 = res;
            }
        }


    }
}