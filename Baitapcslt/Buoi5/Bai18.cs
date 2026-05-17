using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai18
    {
        public static bool KiemTraNamNhuan(int year)
        {
            bool ketqua = true;
            if (year % 4 == 0) 
            { ketqua = true;
                    else ketqua = false;
                        };
            Console.WriteLine(ketqua);
            return ketqua;
        }
        
    }
}
