using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex10
    {
        public static void Run()
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            Console.WriteLine(text);
            string ketqua = text;
            string[] nguyenAm = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            foreach (string chu in nguyenAm)
            {
                ketqua = ketqua.Replace(chu, "");

            }
            Console.WriteLine(ketqua);
            Console.ReadKey();
        }
    }
}
