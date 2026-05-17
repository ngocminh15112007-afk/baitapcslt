using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai3
    {
        public static int TimMax(int a, int b, int c)
        {
            if (a > b && b > c)
                return a;
            else if (b > c && c > a)
                return b;
            else
                return c;

        }
    }
}
