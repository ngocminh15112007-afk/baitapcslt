using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai15
    {
        public static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char i in s)
            {
                if (!result.Contains(i.ToString()))
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
            return result;


        }
    }
}
