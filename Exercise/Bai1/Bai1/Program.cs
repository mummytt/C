using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien
            string strName;
            int iAge;
            int iBirthday;
            // xuat ra man hinh
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Chao mung cac ban den voi hoc vien CNTT NIIT -iPMAC");
            Console.WriteLine("Vui long nhap ten cua ban vao day !!!");
            strName = Console.ReadLine();
            Console.WriteLine("Chao mung {0} da den voi chung toi :D", strName);
            Console.WriteLine("Ban {0} bao nhieu tuoi", strName);
            iAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ban {0} nam nay {1} tuoi", strName, iAge);
            DateTime now = DateTime.Now;
            iBirthday = (now.Year - iAge);
            Console.WriteLine("Ban sinh nam {0}: ", iBirthday);
            Console.ReadLine(); 
        }
    }
}
