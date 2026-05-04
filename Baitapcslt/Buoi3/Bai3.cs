using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    internal class Bai3
    {
        public static void Main()
        {
            Console.WriteLine("Enter the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in the first quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in the second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in the third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in the fourth quadrant.");
            }
            else
            {
                Console.WriteLine("The point is on an axis.");
            }
        }
    }
}
