using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai6
    {
        public static bool KiemTrasonguyento(int n)
        {
            if (n < 2) return false;
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;


            }
        }
    }
}
