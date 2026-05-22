using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public  class Ex5
    {
        public static void Max(int[] arr)
        {
           Random rand = new Random();
           arr = new int[10];
            int i = 0;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            Console.WriteLine("Mang: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            int max = arr[0];
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num > max)  max = num;
                if (num < min) min = num;
            }
            Console.WriteLine(" "+max);
            Console.WriteLine(" "+min);
            return ;


        }
    }
}
