using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class bai13
    {
        public static int TimMin(int[] arr)
        {
            int num  = arr[0] ;
            foreach (int i in arr)
                if (i < num) 
                {
                num = i;
                }
            Console.WriteLine(+num);
            return num;
        }
    }
}
