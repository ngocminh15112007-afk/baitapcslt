using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    internal class Ex4
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}\n {0}{0}{0}{0}",num);
            Console.WriteLine("{0} {0} {0} {0}\n {0}{0}{0}{0}",num);
            Console.ReadKey();

        }
    }
}
