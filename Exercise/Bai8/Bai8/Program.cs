using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap ");
            String str = Console.ReadLine();
            int b = Count(str);
            Console.WriteLine("So ky tu la {0}", b);
            Console.ReadLine();
        }

        static int Count(string n)
        {
            int count = 1;
            String a = n.Trim();
            //Console.WriteLine(a);
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == ' ' && a[i - 1] != ' ')
                {
                    count++;
                }
            }

            return count;

        }

    }
}
