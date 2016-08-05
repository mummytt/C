using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = new int[100];
            // nhap du lieu
            Console.WriteLine("Moi ban nhap so phan tu cho mang");
            int n = int.Parse(Console.ReadLine());
            // nhap du lieu vao mang
            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.Write("Nhap gia tri vao mang thu {0} a[{0}]: ", iCount);
                a[iCount] = int.Parse(Console.ReadLine());
            }

            // in ra man hinh

            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.WriteLine("\t" + a[iCount]);
            }

            // Sap xep mang theo thu tu tu nho den lon
            int change =0;
            for (int iCount = 0; iCount < n; iCount++)
            {
                for (int iCount2 = 0; iCount2 < n; iCount2++)
                {
                    if (a[iCount] < a[iCount2])
                    {
                        change = a[iCount];
                        a[iCount] = a[iCount2];
                        a[iCount2] = change;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Mang sap xep theo gia tri tu nho den lon");
            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.Write("\t" + a[iCount]);
            }

            // xuat ra theo tu lon den nho
            Console.WriteLine();
            Console.WriteLine("Mang sap xep theo gia tri tu nho den lon");
            for (int iCount = n-1; iCount >=0; iCount--)
            {
                Console.Write("\t" + a[iCount]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
