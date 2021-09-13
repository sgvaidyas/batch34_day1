using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_day1
{
    class Program2
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float per;

            Console.WriteLine("Enter name = ");
            name = Console.ReadLine();
            Console.WriteLine("Enter age = ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter per = ");
            per = float.Parse(Console.ReadLine());
            Console.WriteLine("Welcome " + name + " with age = " + age + " & percent = " + per);
        }
    }
}
