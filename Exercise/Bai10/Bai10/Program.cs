using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap");
            string str = Console.ReadLine();
            string[] a = str.Split(' ');
            int max =0;
            int b = a.Length;
            Console.WriteLine("Chieu dai cua mang la " + b);
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine("a["+i+"]=" + a[i].Length );
                if (a[i].Length > max)
                {
                    max = a[i].Length;
                }
            }

            for (int i = 0; i < b; i++)
            {
                if (a[i].Length == max)
                {
                    Console.WriteLine("Phan tu thu " + i + " co chieu dai lon nhat la: " + a[i].Length);
                    break;
                }

            }   
        }
    }
}
