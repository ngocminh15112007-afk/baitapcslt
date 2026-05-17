using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class bai14
    {
        public static int TongCacChuSo(int n)
        {
            int a = Math.Abs(n);
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine($"kq la {sum}");
            return sum;
   }
        
    }
}
