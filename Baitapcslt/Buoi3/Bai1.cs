using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    internal class Bai1
    {
        public static void Run3()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}