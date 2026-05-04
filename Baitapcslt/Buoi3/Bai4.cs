using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai4
    {
        public static void Main()

        {

            Console.WriteLine("Enter the length of triangle sides separated by spaces: ");
            string input = Console.ReadLine();
            int[] canh = Array.ConvertAll(input.Split(' '), int.Parse);
            if (canh[0] == canh[1] && canh[1] == canh[2])
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (canh[0] == canh[1] || canh[1] == canh[2] || canh[0] == canh[2])
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }

        }
    }
}
