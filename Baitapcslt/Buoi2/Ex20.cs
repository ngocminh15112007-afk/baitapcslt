using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex20
    {
        public static void Run()
        {
            Console.WriteLine("Input a string: ");
            string input = Console.ReadLine();
            string chuoinguoc = "";
            for (int i = input.Length - 1; i>=0; i--)

            {
                chuoinguoc = chuoinguoc + input[i];
            }
            bool kq = chuoinguoc == input;
            Console.WriteLine($"The string is {(kq ? "" : "not ")}a palindrome.");

        }
    }
}
