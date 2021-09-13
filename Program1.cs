using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_day1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            Console.WriteLine("Please enter the value of a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value of b = ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("the sum = " + sum);

        }
    }
}
