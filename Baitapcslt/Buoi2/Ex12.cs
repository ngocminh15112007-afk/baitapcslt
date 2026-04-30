using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex12
    {
        public static void Run()
        {
            Console.WriteLine("Input a string (contains at least one 'w' char): ");
            string text = Console.ReadLine();
            int dem = 0;
            foreach (char w in text)
            {
                if (w == 'w')
                {
                    dem++;
                }
                bool ketqua = (dem >= 1 && dem <= 3);
                Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: " + ketqua.ToString());

            }
        }
    }
}
