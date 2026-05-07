using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai14
    {
        public static void Run()
        {
            Console.WriteLine("Enter the radius of the sphere: ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double surfaceArea = 4 * pi * Math.Pow(r, 2);
            double volume = (4.0 / 3.0) * pi * Math.Pow(r, 3);
            Console.WriteLine($"Surface area of the sphere is: {surfaceArea}");
            Console.WriteLine($"Volume of the sphere is: {volume}");
        }
    }
}
