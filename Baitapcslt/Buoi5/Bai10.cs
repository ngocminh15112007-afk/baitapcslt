using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai10
    {
        public static double TinhTrungBinh(int[] arr)
        {
            double result = 1;
            int sum = 0;
            foreach (int num in arr)
            {
                sum +=num;
                result = sum / arr.Length;
            }
            return result;
        }
        
        
    }
}
