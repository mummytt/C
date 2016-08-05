using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] departFrom = { "Sài Gòn", "Đà Nẵng", "Phan Thiết" };
            string[] departTo = { "Hà Nội", "Đà Nẵng", "Phan Thiết" };
            Console.OutputEncoding = Encoding.UTF8;
            string a = string.Empty;
            for (int i = 0; i < departFrom.Length; i++)
            {
                a = departFrom[i];
            }

            Console.WriteLine(a);
        }
    }
}
