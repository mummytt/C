using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice;
            char cData;
            do
            {
                Console.WriteLine("Moi ban chon:");
                Console.WriteLine("1. Bat dau chuong trinh:");
                Console.WriteLine("2. Tro giup:");
                Console.WriteLine("3. About:");
                Console.WriteLine("4. Exit");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        Console.WriteLine("Moi ban nhap vao day 1 ky tu!!!");
                        cData = char.Parse(Console.ReadLine());
                        if (char.IsNumber(cData))
                        {
                            Console.WriteLine("Day la chu so");
                        }
                        else if (char.IsLower(cData))
                        {
                            Console.WriteLine("Day la chu thuong");
                        }
                        else if (char.IsUpper(cData))
                        {
                            Console.WriteLine("Day la chu hoa");

                        }
                        else
                        {
                            Console.WriteLine("Chuong trinh xin bo tay");
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Day la chuong trinh xac dinh ky tu nhap vao");
                        Console.WriteLine("De thoat nhap so 4");
                        Console.WriteLine("De biet thong tin nhap so 3");
                        Console.WriteLine("De nhan su tro giup nhap so 2");
                        Console.WriteLine("De chay chuong trinh nhap so 1");
                        break;
                    case 3:
                        Console.WriteLine("Day la chuong trinh viet boi nhatbinh 0935009529");
                        break;
                    case 4:
                        break;

                }
            }
            while (iChoice != 4);
            Console.ReadLine();
        }
    }
}
