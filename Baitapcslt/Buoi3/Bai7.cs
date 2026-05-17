using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai7
    {
    public static void Run()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of numbers from 1 to " + num + " is: " + sum);
        }
}
}
