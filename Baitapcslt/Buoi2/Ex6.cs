using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex6
    {
        public static void Run()
        {
            string text = "w3resource";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Modified string: " + text.Substring(9, 1) + text.Substring(1, 8) + text.Substring(0, 1));
            string text2 = "Python";
            Console.WriteLine("Original string: " + text2);
            Console.WriteLine("Modified string: " + text2.Substring(5, 1) + text2.Substring(1, 4) + text2.Substring(0, 1)); 
            Console.ReadKey();
        }
    }
}
