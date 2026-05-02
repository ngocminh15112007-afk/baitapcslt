using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Buoi3
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            
           Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
           
        }
        public static void Run2()
        {
            Console.WriteLine("y\tx = y² + 2y + 1");

            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"{y}\t{x}");
            }
        }
        public static void Run3()
        {
            Console.Write("Input distance (meters): ");
            float distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (hours): ");
            float hr = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (minutes): ");
            float min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (seconds): ");
            float sec = Convert.ToSingle(Console.ReadLine());

            float totalHours = hr + (min / 60.0f) + (sec / 3600.0f);

            float kph = (distance / 1000.0f) / totalHours;
            float mph = kph / 1.609f;

            Console.WriteLine($"Your speed in km/h is {kph}");
            Console.WriteLine($"Your speed in miles/h is {mph}");
        }
        public static void Run4()
        {
            Console.Write("Enter the radius of the sphere: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            double surfaceArea = 4 * pi * Math.Pow(r, 2);
            double volume = (4.0 / 3.0) * pi * Math.Pow(r, 3);

            Console.WriteLine($"Surface Area: {surfaceArea}");
            Console.WriteLine($"Volume: {volume}");
        }
        public static void Run5()
        {
            Console.Write("Enter a character: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(symbol))
            {
                Console.WriteLine("It's a digit.");
            }
            else if ("aeiouAEIOU".Contains(symbol))
            {
                Console.WriteLine("It's a vowel.");
            }
            else
            {
                Console.WriteLine("It's another symbol or a consonant.");
            }
        }

    }
}
