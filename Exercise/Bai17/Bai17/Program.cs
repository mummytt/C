using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int  n= 0;
            int x, k, k1;
            Console.WriteLine("Moi ban nhap n");
            n = int.Parse(Console.ReadLine());
            nhapmang(a,n);
            xuatmang(a,n);
            Console.WriteLine("nhap gia tri x can them vao");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can them vao");
            k = int.Parse(Console.ReadLine());
            chenX(a, n, x, k);
            Console.WriteLine("Moi ban nhap n");
            n = int.Parse(Console.ReadLine());
            nhapmang(a, n);
            xuatmang(a, n);
            Console.WriteLine("Nhap vi tri can xoa");
            k1 = int.Parse(Console.ReadLine());
            xoaX(a, n, k1);
            Console.ReadLine();
        }

        public static void nhapmang(int[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu a[{0}]", i);
                a[i] = int.Parse (Console.ReadLine());
            }
        }

        public static void xuatmang(int[] a, int n)
        {
            int i;
            Console.Write("Mang sau khi xuat la: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
        //x la gia tri can chen
        //k la vi tri chen so x
        public static void chenX(int[] a, int n, int x, int k)
        {
                for (int i = n-1; i >= k; i--)
                {
                    a[i + 1] = a[i];
                }
                n = n + 1;
                a[k] = x;
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a[i] + " ");
                }
        }


        public static void xoaX(int[] a, int n, int k)
        {
            for (int i = k + 1; i < n; i++)
            {
                a[i - 1] = a[i];
            }
            n--;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
