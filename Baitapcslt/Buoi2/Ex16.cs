using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex16
    {
        public static void Run()
        {
            Console.WriteLine("Enter an array of integers: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("array = [" + string.Join(", ", arr) + "]");
            int sodau = arr[0];
            int socuoi = arr[arr.Length - 1];
            bool ketqua = sodau == socuoi;
            Console.WriteLine($"{ketqua}");
            Console.ReadKey();
        }
    }
}
