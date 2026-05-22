using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex8
    {
        public static void Xoasogiong(int[] arr)
        {
            Random rand = new Random(10);
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            foreach (int num in arr)
                Console.Write(num + " ");
            // taoj mảng mới để đựng các số duy nhất, kthuoc = tối đa mãng cũ

            int[] arr2 = new int[arr.Length];
            int j = 0;
            //đếm lượng phần từ duy nhất
            for (int i = 0; i < arr.Length; i++)
            {
                bool daxuathien = false;


                for (int k = 0; k < j; k++)
                {
                    if (arr[i] == arr2[k])
                    {
                        daxuathien = true;
                        break;
                    }

                }
                if (daxuathien == false)
                {
                    arr2[j] = arr[i];
                    j++;
                }
            }
            int[] mangchinh = new int[j];
            for (int i = 0; i < j; i++)
            {
                mangchinh[i] = arr2[j];
                Console.WriteLine(mangchinh[i] + " ");
            }
        }


         

    }
}
