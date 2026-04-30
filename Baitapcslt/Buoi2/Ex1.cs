using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex1
    {
        public static void Run()
 
            {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number}*{i} ={number * i}");

            }
            Console.ReadLine();
        }
    }
}