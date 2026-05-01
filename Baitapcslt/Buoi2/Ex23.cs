using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex23
    {
        public static void Run()
        {
            Console.WriteLine("Width of rectangle: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height of rectangle: ");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
