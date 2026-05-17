using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai9
    {
        public static void Run()
        {
            Console.WriteLine("Nhập số lượng nhân tử: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"1/{i}");
                sum += 1.0 / i;
                if (i < n)
                { Console.Write(" + "); }



            }
            Console.WriteLine($" = {sum}");

        }
    }
}
