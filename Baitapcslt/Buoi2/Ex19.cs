using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex19
    {
        public static void Run()
        {
            Console.WriteLine("Enter an array of integers:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("array = [" + string.Join(", ", arr) + "]");
            foreach (int I in arr)
            {
                bool ketqua = I % 2 != 0;
                Console.WriteLine($"{ketqua}");
                int[] SOLE = Array.FindAll(arr, x => x % 2 != 0);
                Console.WriteLine("ODD ARRAY IS: [" + string.Join(", ", SOLE) + "]");
                Console.ReadKey();
            }

        }
    }
}
