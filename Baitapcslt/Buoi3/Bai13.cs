using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai13

    {
        public static void Run()
        {
            Console.WriteLine("Enter a kilometer: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a minute: ");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second: ");
            int second = int.Parse(Console.ReadLine());
            int speed = (int)(km / ((hour * 3600 + minute * 60 + second) / 3600.0));
            Console.WriteLine($"Your speed is {speed} km/h");

        }
    }
}
