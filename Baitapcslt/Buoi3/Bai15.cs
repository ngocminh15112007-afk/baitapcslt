using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai15
    {
        public static void Run()
        {
            Console.WriteLine("Enter a character: ");
            char c = char.Parse(Console.ReadLine()) ;
            Console.WriteLine(c);
            if (char.IsDigit(c))
            {
                Console.WriteLine("The character is a digit.");
            }
            else if ("ueoaiUEOAI".Contains(c))
            {
                Console.WriteLine("The character is a vowel.");
            }
            else
            {
                Console.WriteLine("The character is neither a digit nor a letter.");
            }

        }
    }
}
