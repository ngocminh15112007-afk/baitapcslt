using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex1
    {
        public static void Average(int[] arr)
        {
            Random rand = new Random();
            arr = new int[50]; 

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 50); 

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i]; 

            double avg = (double)sum / arr.Length;
            Console.WriteLine("Trung bình: " + avg);
        }
    }
    }