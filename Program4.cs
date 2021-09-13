using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_day1
{
    class Program4
    {
        static void Main(string[] args)
        {
            int per;
            Console.WriteLine("Enter percent = ");
            per = Convert.ToInt32(Console.ReadLine());
            
            switch(per)
            {
                case int n when (n >= 80 && n <= 100):
                    Console.WriteLine("distinction");
                    break;
                case int n when (n >= 60 && n <= 79):
                    Console.WriteLine("FC");
                    break;
                case int n when (n >= 35 && n <= 59):
                    Console.WriteLine("PC");
                    break;
                case int n when (n >= 0 && n <= 34):
                    Console.WriteLine("FAIL");
                    break;
                default: Console.WriteLine("Invalid");break;
            }
        }
    }
}
