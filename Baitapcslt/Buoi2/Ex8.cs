using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex8
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int tong = num1 + num2;

            if (num1 == num2)
            {
                tong = tong * 3; 
                    }
            Console.WriteLine("The result is: {0}", tong);
            Console.ReadKey();


        }
    }
}
