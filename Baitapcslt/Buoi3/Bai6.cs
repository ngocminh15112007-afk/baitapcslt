using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai6
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int multi = 0;
                multi = num * i;
                Console.WriteLine(num + " x " + i + " = " + multi);
            }
        }
    }
}