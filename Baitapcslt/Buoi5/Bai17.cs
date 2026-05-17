using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai17
    {
        public static string DecimalToBinary(int n)
        {
            string result = "";
            while (n>0)
            {
                result = n % 2 + result;
                n /= 2;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
