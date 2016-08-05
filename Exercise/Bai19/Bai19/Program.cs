using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai19
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] a = new int[100];
            Console.WriteLine("Moi ban nhap n");
            int n = int.Parse(Console.ReadLine());

            // nhap mang
            for (int i =0; i<n; i++)
            {
                Console.Write("Phan tu A[{0}]",i);
                a[i] = int.Parse(Console.ReadLine());
            }

            // xuat mang
            Console.Write("Mang sau khi nhap: ");
            for (int i =0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }

            // kiem tra so nguyen to
            Console.WriteLine();
            Console.WriteLine("So nguyen to trong mang do la");
            for (int i = 0; i < n;i++ )
            {
                if (songuyento(a[i])==1)
                {
                    Console.Write(a[i] + " ");
                }

            }
               
            // dao nguoc mang
            Console.WriteLine();
            Console.WriteLine("Mang sau khi dao nguoc");
            for (int i=n-1; i>=0; i--)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();


        }

        public static int songuyento(int n)
        {
            if (n == 1) return 1;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        
        }
    }
}
