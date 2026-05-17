using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai7
    {
        public static void InFibonacci(int n)
        {
            int a = 0; int b = 1;
            for ( int i = 0; i < n; i++)
            {
                Console.Write(a+" ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine(); 
        }

    }
}
