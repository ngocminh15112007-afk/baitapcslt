using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex18
    {
        public static void Run()
        {
            Console.WriteLine("Enter an array of integers: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("array = [" + string.Join(", ", arr) + "]");
            if (arr[0] > arr[arr.Length - 1])
            { Console.WriteLine("Highest value of an array is " + arr[0]); }
            else
                { Console.WriteLine("Highest value of an array is " + arr[arr.Length - 1]); }
               Console.ReadKey();
        }
    }
}
