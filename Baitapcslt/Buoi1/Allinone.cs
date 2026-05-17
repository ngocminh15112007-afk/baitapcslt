using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi1
{
    public class Allinone
    {
        static void SumTwoNumbers()
        {
            //1. Sum Two Numbers
            Console.WriteLine("======1. Sum Two Numbers======");
            Console.WriteLine("Enter the first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"Sum of {a} and {b} is {sum}");
            Console.ReadKey();
        }
        static void SwapVariables()
        {
            Console.WriteLine("======2. Swap Variables======");
            Console.WriteLine("Enter the first number:");
            int DiemToan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping: DiemToan = {DiemToan}");
            Console.WriteLine("Enter the second number:");
            int DiemVan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping: DiemVan = {DiemVan}");
            int temp = DiemToan;
            DiemToan = DiemVan;
            DiemVan = temp;
            Console.WriteLine($"After swapping: DiemToan = {DiemToan}, DiemVan = {DiemVan}");
            Console.ReadKey();
        }

        static void MultiplyTwoFloatingPointNumbers()
        {
            Console.WriteLine("======3. Multiply Two Floating Point Numbers======");
            Console.WriteLine("Enter the first floating-point number:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the second floating-point number:");
            float num2 = Convert.ToSingle(Console.ReadLine());
            float product = num1 * num2;
            Console.WriteLine($"Product of {num1} and {num2} is {product}");
            Console.ReadKey();
        }

        static void FeetToMeter()
        {
            Console.WriteLine("======4. Convert Feet to Meters======");
            Console.WriteLine("Enter the number of feet:");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} is equal to {meters}");
            Console.ReadKey();
        }

        static void ConvertTemperature()

        {
            Console.WriteLine("======5.Temperature Conversion======");
            Console.WriteLine("Enter the temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{celsius}°C = {(celsius * 9 / 5) + 32}°F");
            Console.ReadKey();

            Console.WriteLine("enter the temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{fahrenheit}°F = {(fahrenheit - 32) * 5 / 9}°C");
            Console.ReadKey();

        }

        static void SizeofData()

        {
            Console.WriteLine("====== 6.Size of Data Types ====== ");
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
            Console.ReadKey();
        }

        static void PrintASCII()
        {
            Console.WriteLine("====== 7. Print ASCII ====== ");
            Console.WriteLine("Enter a character:");
            char character = Convert.ToChar(Console.ReadLine()[0]);
            Console.WriteLine($"ASCII value of '{character}' is {(int)character}");
            Console.ReadKey();
        }

        static void AreaOfCircle()
        {
            Console.WriteLine("====== 8. Area of Circle ====== ");
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of the circle with radius {radius} is {Math.PI * radius * radius}");
            Console.ReadLine();

        }

        static void AreaOfSquare()
        {
            Console.WriteLine("====== 9. Area of Square ====== ");
            Console.WriteLine("Enter the length of the square: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of the square with length {length} is {length * length}");
            Console.ReadKey();
        }

        static void ConvertDays()
        {
            Console.WriteLine("====== 10. Convert Days to Years, Weeks and Days ====== ");
            Console.WriteLine("Enter the numbers of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"{days} is equal to {years} years, {weeks} weeks and {remainingDays} days");
            Console.ReadLine();

        }
       


        }
    }

