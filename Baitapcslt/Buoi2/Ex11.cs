using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex11
    {
        public static void Run()
        {
            Console.WriteLine("Enter first integer: ");
            int num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("0");
            }
            else
            {
                int khoangcach1 = Math.Abs (num1 - 20);
                int khoangcach2 = Math.Abs(num2 - 20);
                if (khoangcach1 > khoangcach2)
                { Console.WriteLine(num2);}
                else {  Console.WriteLine(num1); }

            }
            Console.ReadKey();
        }
    }
}
