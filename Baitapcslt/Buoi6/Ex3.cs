using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex3
    {
        public static int Max(int[] arr)
        {

            Random rand = new Random();
            arr = new int[50];
           
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 50);
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max) arr[i] = max;
            Console.WriteLine(max);
            return max;
        }
    }
}
