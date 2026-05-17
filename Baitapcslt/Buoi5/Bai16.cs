using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai16
    {
        public static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b!=0)
            {
                int temp = b;
                b = a % b;
                a = b;
            }
            Console.WriteLine("a");
            return a;

        }
    }
}
