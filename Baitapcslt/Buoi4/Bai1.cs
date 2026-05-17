using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi4
{
    internal class Bai1
    {
        public static int FindMax(params int[] rest)
        {
            int max = rest[0];
            foreach (int i in rest)
            {
                if (i > max)
                    max = i;

            }
            Console.WriteLine($"Max value is: {max}");
            return max;
        }
        
    }
}
