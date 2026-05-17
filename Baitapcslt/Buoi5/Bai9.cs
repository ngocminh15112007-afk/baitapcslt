using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai9
    {
        public static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;
            for (int i = 1; i <= y; i++)
            {
                ketQua *= x;
            }
            Console.WriteLine($"x^y={ketQua}");
            return ketQua;
        }
        
       }
}