using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace baitapcslt.Buoi3
{
    public class Bai11
    {
        public void Main()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];
            if (op == '-')
            {
                Console.WriteLine("a-b = " + (a - b));
            }
            else if (op == '+')
            {
                Console.WriteLine("a+b = " + (a + b));
            }
            else if (op == '*')
            {
                Console.WriteLine("a*b = " + (a * b));
            }
            else if (op == '/')
            {
                if (b != 0)
                {
                    Console.WriteLine("a/b = " + ((double)a / b));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}
