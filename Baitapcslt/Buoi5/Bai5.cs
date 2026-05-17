using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi5
{
    public class Bai5
    {
        public static string DaoNguocChuoi(string input)
        {
            Console.WriteLine("Enter a string: ");
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string (arr); 
        }
    }
}
