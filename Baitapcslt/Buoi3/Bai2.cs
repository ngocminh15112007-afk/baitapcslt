using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    internal class Bai2
    {
        public static void Main()
        {
            Console.WriteLine("Enter 3 integers separated by spaces: ");
            string input = Console.ReadLine();
            int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
            if (num[0] > num[1] && num[0] > num[2])
            {
                Console.WriteLine("The largest number is: " + num[0]);
            }
            else if (num[1] > num[0] && num[1] > num[2])
            {
                Console.WriteLine("The largest number is: " + num[1]);
            }
            else
            {
                Console.WriteLine("The largest number is: " + num[2]);
            }
        }
    }
}
