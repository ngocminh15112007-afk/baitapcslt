using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex14
    {
        public static void Run()
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            string ketqua = "";
            for (int i = 0; i < text.Length; i += 2) 
            { ketqua = ketqua + text[i]; }
            Console.WriteLine(ketqua);
            Console.ReadKey();

        }
    }
}
