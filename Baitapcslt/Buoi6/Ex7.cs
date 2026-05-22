using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex7
    {
        public static void Timsogiong(int[] arr)
        {
            Random rand = new Random();
            arr = new int[10];
            int i = 0;
            for (i=0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(10);
            }
            foreach(int num in arr)
            Console.Write($"Day so la:{num} + ");

            //tim so giong
            int j = 0;
            int[] arr2 = new int[10];
            for (i = 0; i<arr.Length; i++) 
            { 
                for (j =0; j<arr2.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }

        }
    }
}
