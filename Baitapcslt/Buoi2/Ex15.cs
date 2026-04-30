using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex15
    {
        public static void Run()
        {
            Console.WriteLine("Enter an array of integers: ");
            string input = Console.ReadLine();
            string[] mangChuoi = input.Split(' ');
            Console.WriteLine("Specific integer:");
            int num = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int dem = 0;
            foreach (string n in mangChuoi)
            {
                int s = int.Parse(n);
                {
                    if (s == num)
                    { dem++; }

                }
                Console.WriteLine("the number of occurrences of {0} in the array is: {1}", input, dem);
                Console.ReadKey();


            }
        }
    }
}
