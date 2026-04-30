using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex7
    {
        public static void Run()
        {
            Console.WriteLine("Enter first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            bool ketqua = num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0;
            Console.WriteLine("Check if one is negative and one is positive: {0}", ketqua);
            Console.ReadKey();
        }
    }
}
