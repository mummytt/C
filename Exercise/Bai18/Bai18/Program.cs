using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap chuoi: ");
            string a = Console.ReadLine();
            string[] mangNhap = a.Split(' ');
            string[] mang2 = mangNhap.Distinct().ToArray();
            for (int i = 0; i < mang2.Length; i++)
            {
                Console.Write(mang2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
