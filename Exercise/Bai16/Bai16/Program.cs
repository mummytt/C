using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi");
            string a = Console.ReadLine();

            string[] b = a.Split(' ');
            string c = "";
            int max = 0;
            int d = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (max < b[i].Length)
                {
                    max = b[i].Length;
                    c = b[i];
                    d = i;
                }


            }
            Console.WriteLine("Tu dai nhat do la: " + c);
            Console.WriteLine("Tu dai nhat do co vi tri la: " + d);
            Console.WriteLine("Tu dai nhat la tu co gia tri la {0}", max);
        }
    }
}
