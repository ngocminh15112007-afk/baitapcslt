using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcslt.Buoi2
{
    public class Ex22
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số lượng lon nhớt khách hàng mua: ");
            int soluonglon = int.Parse(Console.ReadLine());
            int thanhtien = soluonglon * 27000;
            int thuongnon = soluonglon / 3;
            int thuongviet = (soluonglon % 3) * 2;
            Console.WriteLine($"Thành tiền: {thanhtien}");
            Console.WriteLine($"Số nón được tặng: {thuongnon}");
            Console.WriteLine($"Số viết được tặng: {thuongviet}");
            Console.ReadKey();
        }
    }
}
