using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi4
{
    internal class Bai2
    {
        public static long Factorial(int n)
        {
            if (n < 0) return -1;
            else if (n == 0 || n == 1) return 1;
            else
            {
                long ketQua = 1;
                for (int i = 2; i<=n; i++)
                {
                    ketQua *= i;
                }
                Console.WriteLine($"Factorial of {n} is: {ketQua}");
                return ketQua;
            }
        }
    }
}
