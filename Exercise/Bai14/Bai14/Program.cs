using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] A = new string[255];
            //string[] B = new string[255];
            // nhap du lieu vao mang
            Console.WriteLine("Nhap so phan tu cho mang A:");
            int n = int.Parse(Console.ReadLine());
            string[] A = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu A[{0}]",i);
                A[i] = Console.ReadLine();
            }
            Console.Write("Mang xuat ra la: ");
            // xuat du lieu 
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            // nhap du lieu vao mang
            Console.WriteLine("\nNhap so phan tu cho mang B:");
            int m = int.Parse(Console.ReadLine());
            string[] B = new string[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write("Phan tu B[{0}] ");
                B[i] = Console.ReadLine();
            }
            Console.Write("Mang xuat ra la: ");
            // xuat du lieu 
            for (int i = 0; i < m; i++)
            {
                Console.Write(B[i] + " ");
            }

            // tim phan tu thuoc ve mang A va thuoc mang B
            string[] C = new string[255];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i] == B[j])
                    {
                        C[count] = A[i];
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.WriteLine("Phan tu thuoc mang A va mang B la: ");
            for (int i = 0; i < count; i++)
            {   
                Console.WriteLine(C[i]);
            }

            // Tim phan tu thuoc A hoac B
            int count2 =0;
            for (int i = 0; i < n; i++)
            {
                C[count2] = A[i];
                count2++;

            }

            for (int j = 0; j < m; j++)
            {
                if (!Check(C,B[j]))
                {
                    C[count2] = B[j];
                    count2++;
                }
            }
            Console.WriteLine("Phan tu thuoc mang A hoac mang B la: ");
            for (int i = 0; i < count2; i++)
            {
                Console.Write(C[i] + " ");
            }

            // Tim C = A\B tuc la phan tu thuoc ve A va k thuoc B
            int count1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i]!=B[j])
                    {
                        C[count1] = A[i];
                        m--;
                        count1++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Phan tu thuoc mang A va khong thuoc mang B la: ");
            for (int i = 0; i < count1; i++)
            {
                Console.WriteLine(C[i]);
            }

            Console.ReadLine();
        
        }

        public static Boolean Check(string []a, string b)
        {
            bool check = false;
            if (a.Contains(b))
            {
                check = true;
            }
            return check;
        }


    }
}
