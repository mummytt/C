using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {  
            // viet lai string cho truoc theo dung chuan 
            string a = "     tran      le         nhat                          binh";
            a = a.Trim();
            // cach 1:
            //while (a.Contains("  "))
            //{
            //    a = a.Replace("  ", " ");
            //}
            // cach 2:
            do {
                a = a.Replace("  ", " ");

            } while(a.IndexOf("  ")!=-1);

            Console.WriteLine(a);
  
        }
    }
}
