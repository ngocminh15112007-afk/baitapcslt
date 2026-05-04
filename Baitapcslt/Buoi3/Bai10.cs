using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace baitapcslt.Buoi3
{
    public class Bai10
    {
        public static void Run1()
    
        {
           

                    Console.Write("Nhập một số nguyên để kiểm tra: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    bool isPrime = true;

                  
                    if (n <= 1)
                    {
                        isPrime = false;
                    }
                    else
                    {
                       
                        for (int i = 2; i <= n / 2; i++)
                        {
                           
                            if (n % i == 0)
                            {
                                isPrime = false;
                                break; 
                            }
                        }
                    }

                   
                    if (isPrime)
                    {
                        Console.WriteLine($"{n} là một số nguyên tố.");
                    }
                    else
                    {
                        Console.WriteLine($"{n} không phải là số nguyên tố.");
                    }
                }
            }
        }
