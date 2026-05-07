using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai12
    {
        public static void  Run()
        {
            Console.WriteLine("x=y^2 + 2y + 1");
            int ketqua = 0;
            for (int y = -5; y <= 5; y++)
            {
                ketqua = (y * y) + (2 * y) + 1;
                Console.WriteLine($"{y}\t{ketqua}");
            }
        }
    }   
}
