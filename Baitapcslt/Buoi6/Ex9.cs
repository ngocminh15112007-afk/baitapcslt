using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex9
    {
        public static void Run33()
        {
            int[] arr = new int[10];
            // yeu cau nhap 10 so
            Console.WriteLine("Nhap 10 so nguyen: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"So thu {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i= 0; i<arr.Length -1; i++)
            {
                for (int j = 0; j<arr.Length-1-i;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];     
                        arr[j] = arr[j + 1];     
                        arr[j + 1] = temp;       
                    }
                }
            }
            Console.WriteLine("\nMang sau khi sap xep tang dan:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}



       