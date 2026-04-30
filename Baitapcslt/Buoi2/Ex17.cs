using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex17
    {
        public static void Run()
        {
            Console.WriteLine("Enter an array of integers: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("array = [" + string.Join(", ", arr) + "]");
            Console.WriteLine("Enter an array of integers 2: ");
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("array2 = [" + string.Join(", ", arr2) + "]");
            bool ketqua = arr[0] == arr2[0] || arr[arr.Length -1] == arr2[arr2.Length - 1];
            Console.WriteLine($"{ketqua}");
            Console.ReadKey();
        }
    }
}
