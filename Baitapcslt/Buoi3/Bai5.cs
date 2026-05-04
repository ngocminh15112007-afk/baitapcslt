using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai5
    {
        public static void Main()
        {
            Console.WriteLine("Enter 10 integers separated by spaces: ");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                sum += numbers[i];
                Console.WriteLine(sum);

                int average = sum / numbers.Length;
                Console.WriteLine(average);

            }
        }
    }

}