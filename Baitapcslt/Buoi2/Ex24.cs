using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex24
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random sobimat = new Random();
            int so = sobimat.Next(0, 101);
            bool kq = false;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"Lần đoán thứ {i}: ");
                int soDoan = int.Parse(Console.ReadLine());
                if (soDoan == so)
                {
                    Console.WriteLine("CHÚC MỪNG BẠN ĐOÁN TRÚNG!");
                    kq = true;
                    break;
                }
                else if (soDoan > so)
                {
                    Console.WriteLine("SỐ ĐOÁN LỚN HƠN SỐ BÍ MẬT");
                }
                else

                {
                    Console.WriteLine("SỐ BẠN ĐOÁN NHỎ HƠN SỐ BÍ MẬT");
                }

                


            }
            if (!kq)
            {
                Console.WriteLine($"BẠN ĐÃ HẾT LƯỢT ĐOÁN! SỐ BÍ MẬT LÀ: {so}");
            }


        }
    }
}
