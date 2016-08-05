using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = new int[100];
            int sum = 0;
            // nhap du lieu
            Console.WriteLine("Moi ban nhap n vao day");
            int n = int.Parse(Console.ReadLine());
            // nhap du lieu vao mang
            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.Write("Nhap gia tri vao mang thu {0} a[{0}]: ", iCount);
                a[iCount] = int.Parse(Console.ReadLine());
            }
            

            // in mang ra man hinh
            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.Write("\t" + a[iCount]);
            }

            // cong mang 
            for (int iCount = 0; iCount < n; iCount++)
            {
                sum += a[iCount];
            }
            Console.WriteLine();
            Console.WriteLine("Tong cua mang da cho la : {0}" ,sum);
            Console.ReadLine();
        }
    }
}
