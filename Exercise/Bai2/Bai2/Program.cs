using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai bao bien
            float a, b, c, x, x1, x2, d;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Giải phương trình bậc 2");
            Console.WriteLine("Mời bạn nhập a,b,c");
            Console.WriteLine("Nhap gia tri a vao day");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri b vao day");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri c vao day");
            c = float.Parse(Console.ReadLine());
            // phan xu ly
            d = b * b - 4 * a * c;
            if (a != 0)
            {
                if (d < 0)
                {
                    Console.WriteLine("Pt vo nghiem");
                }
                if (d == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine("Pt co nghiem kep x1=x2={0}", x);
                }
                if (d > 0)
                {
                    x1 = (-b - (float)Math.Sqrt(d)) / 2 * a;
                    x2 = (-b + (float)Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("Pt co nghiem x1 = {0}", x1);
                    Console.WriteLine("Pt co nghiem x2 = {0}", x2);
                }
            }
            else
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Pt co vo so nghiem");
                }
                if (b == 0 && c != 0)
                {
                    Console.WriteLine("Pt co vo nghiem");
                }

                if (b != 0)
                {
                    x = -c / b;
                    Console.WriteLine("Pt co nghiem x = {0}", x);
                }

            }
        }
    }
}
