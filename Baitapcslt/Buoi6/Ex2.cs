using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex2
    {
        public static bool Contains(int[] arr)
        {
            Random rand = new Random();
            arr = new int[50];
            bool ketqua = true;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 50);
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 20)
                    ketqua = true;
                else ketqua = false;
            Console.WriteLine($"Chua 20? {ketqua}");
            return ketqua;
        }
    }
}
