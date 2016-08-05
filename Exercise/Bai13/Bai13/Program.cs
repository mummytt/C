using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("Moi ban nhap chuoi ky tu");
            string a = Console.ReadLine();
            string str = a.Trim();
            string[] b = str.Split(' ');
            int c = b.Length;
            for (i = 0; i < c; i++)
            {
                Console.WriteLine("Ky tu b[" + i + "] la {0} ", b[i]);
            }

            // xoa phan tu giong nhau trong mang
            for (i = 0; i < c - 1; i++)
            {
                j = i + 1;
                while (j < c)
                {
                    if (b[i] == b[j])
                    {
                        for (k = j; k < c - 1; k++)
                        {
                            b[k] = b[k + 1];
                        }
                        c--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            for (i = 0; i < c ; i++)
            {
                Console.WriteLine(b[i]+ " ");
            }
            
                Console.ReadLine();
        }
    }
}
