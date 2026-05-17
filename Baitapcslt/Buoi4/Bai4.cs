using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi4
{
    internal class Bai4
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n; i++)
                if (IsPrime(i)) return true; return false;
        }
    }
}