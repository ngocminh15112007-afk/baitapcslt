using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class NumberTriangle
    {
        public static void  Run()
        {
            Console.Write("Nhập số hàng cho tam giác: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}
