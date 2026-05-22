using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex6
    {
        public static void Daomang(int[] arr)
        {
            Random rand = new Random();
            arr = new int[10];
            int i = 0;
            for (i=0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(10);
            }
            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
            // tao mang moi
            int[] arr2 = new int[10];
            int j = 0;

            for (i=arr.Length-1 ;i>=0;i--)
            {
                arr2[j] = arr[i];
                j++;
            }
            foreach (int num2 in arr2)
            { Console.Write(num2 + " "); }
            return;


        }
    }
}
