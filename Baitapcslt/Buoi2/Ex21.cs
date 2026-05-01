using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex21
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Input Toiec aim: ");
            Console.ReadLine();
            Console.WriteLine("Wish you meet your target!");
            Console.ReadKey();

            Console.WriteLine("Nhập số hộp Tok: ");
            int sotok = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số bánh tráng: ");
            int sobanhtrang = int.Parse(Console.ReadLine());
            int doanhthu = (sotok * 20000) + (sobanhtrang * 10000);
            Console.WriteLine($"Doanh thu: {doanhthu}");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nhập tên khách hàng thứ {i + 1}: ");
                string tenkhachhang = Console.ReadLine();
                Console.WriteLine($"Nhập hóa đơn của khách hàng thứ {i + 1}: ");
                int hoadon = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tên khách hàng: {tenkhachhang} | Hóa đơn: {hoadon}");

                if (tenkhachhang == "Dung" || tenkhachhang == "Phi")
                {
                    int hoadon1 = hoadon * 90 / 100;
                    Console.WriteLine($"Hóa đơn sau khi được giảm giá: {hoadon1}");
                }
                else
                { Console.WriteLine($"Hóa đơn không được giảm giá: {hoadon}"); }
                Console.ReadKey();

            }



        }
    }
}


