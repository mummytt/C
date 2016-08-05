using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Empty;
            string str = string.Empty;
            string result = string.Empty;
            Console.WriteLine("Moi ban nhap chuoi");
            a = Console.ReadLine();
            str = a.ToLower();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }

            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string s = words[i];
                if (s.Length > 0)
                {
                    words[i] = s[0].ToString().ToUpper() + s.Substring(1);
                }
            }

            result = string.Join(" ", words);
            Console.WriteLine("Chuoi sau khi chuan hoa: " + result);
            Console.ReadLine();
        }
    }
}
