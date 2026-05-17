using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai8
    {
        public static int DemNguyenAm(string s)
        {
            int count = 0;
            string chuoi = "ueoaiUEOAI";
            foreach (char c in s)
            {
                if (chuoi.Contains(c))
                    count++;
            }
            Console.WriteLine($"So luong nguyen am trong chuoi la: {count}");
            return count;
        }
    }
}
