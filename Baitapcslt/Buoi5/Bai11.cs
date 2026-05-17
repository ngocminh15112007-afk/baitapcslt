using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace baitapcslt.Buoi5
{
    public class Bai11
    {
        public static bool KiemTraDoiXung(string s)
        {
            
            string x = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                x += s[i];
            }
            if (s != x)
                return false;
            else return true;
           
        }
    }
}
