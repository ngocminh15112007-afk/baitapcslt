using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi6
{
    public class Ex10
    {
        public static void run34()
        {
            Console.WriteLine("Nhap vao mot cau: ");
            string cau = Console.ReadLine();
            Console.WriteLine("Nhap tu ban muon tim: ");
            string tucantim = Console.ReadLine();
            string[] mangcactu = cau.Split(' ');
            bool timthay = false;
            for (int i = 0; i<mangcactu.Length; i++)
            {
                if (mangcactu[i] == tucantim)
                {
                    timthay = true;
                    break;
                }
            }
            if (timthay = true)
            {
                Console.WriteLine("Co tu can tim");
            }
            else
            {
                Console.WriteLine("Khong co");
            }
        }
            
    }
}
