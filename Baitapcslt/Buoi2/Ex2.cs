using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex2

    {
        public static void Run()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());
            short average = (short)((number1 + number2 + number3) / 3);
            Console.WriteLine($"The average is: {average}");
            Console.ReadLine();
        }
    }
}




