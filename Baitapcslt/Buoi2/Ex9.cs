using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex9
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int hieu = Math.Abs(num1 - num2);
            if (num1 > num2) ;
            {
                hieu = hieu * 2;
            }
            Console.WriteLine("The result is: {0}", hieu);
            Console.ReadKey();
        }
    }
}
