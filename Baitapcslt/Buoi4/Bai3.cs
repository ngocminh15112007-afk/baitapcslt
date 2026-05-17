using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi4
{
    internal class Bai3
    {
        public static bool Prime(int n)
        {
            if (n < 2) return false;
            if (n >= 2)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0) return false;
                }

            }
            Console.WriteLine($"{n} is a prime number.");
            return true;
        }
    }
}
