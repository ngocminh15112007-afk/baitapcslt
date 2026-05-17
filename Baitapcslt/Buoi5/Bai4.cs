using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai4
    {
        public static long TinhGiaithua (int n)
        {
            long result = 1;
            for (int i = 1; i<n; i++ )
            {
                result *= i;
            }
            return result;
        }
    }
}
