using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex4
    {
        public static void Xoakitu(int[] arr)
        {//tạo mảng random và viết lại
            Random rand = new Random();
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 10);
            foreach (int num in arr)
            Console.WriteLine(" " + num); 

            //chọn số cần xóa
            Console.WriteLine("Write a number u wanna remove: ");
            int soXoa = int.Parse(Console.ReadLine());

            // có mấy số cần xóa

           int dem = 0;
        foreach (int num in arr)
        {
            if (num == soXoa) dem++;
        }
            //tạo mảng mới đựng cái đã xóa
            int[] mangMoi = new int[arr.Length - dem];
            int j = 0;

            //đi tìm số xóa đó r so nó với từng số trong dãy, nếu bằng thì giữ, ko bằng thì remove
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != soXoa)
                {
                    mangMoi[j] = arr[i];
                    j++;

                }
            }
                foreach (int num in mangMoi)
                { Console.WriteLine(" " + num); }
                Console.WriteLine();
            }

        }
    }

