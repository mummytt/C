using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            FileText ft = new FileText();
            ft.FileName = @"C:\a.txt";
            //ft.WriteData();
            ft.ReadData();
            Console.ReadLine();
        }
    }
}
