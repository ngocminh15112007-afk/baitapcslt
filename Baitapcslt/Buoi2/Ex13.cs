using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex13
    {
        public static void Run()
        {
            Console.WriteLine("Enter string start with 'w': ");
            string text = Console.ReadLine();
            bool ketqua = text.StartsWith("w") && !text.StartsWith("www");
            Console.WriteLine(ketqua);
            Console.ReadKey();
        }
    }
}
